using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001065 RID: 4197
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneEntityMoveCsReq : IMessage<SceneEntityMoveCsReq>, IMessage, IEquatable<SceneEntityMoveCsReq>, IDeepCloneable<SceneEntityMoveCsReq>, IBufferMessage
	{
		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x0600BAE1 RID: 47841 RVA: 0x001F6A2F File Offset: 0x001F4C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneEntityMoveCsReq> Parser
		{
			get
			{
				return SceneEntityMoveCsReq._parser;
			}
		}

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x0600BAE2 RID: 47842 RVA: 0x001F6A36 File Offset: 0x001F4C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneEntityMoveCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x0600BAE3 RID: 47843 RVA: 0x001F6A48 File Offset: 0x001F4C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneEntityMoveCsReq.Descriptor;
			}
		}

		// Token: 0x0600BAE4 RID: 47844 RVA: 0x001F6A4F File Offset: 0x001F4C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityMoveCsReq()
		{
		}

		// Token: 0x0600BAE5 RID: 47845 RVA: 0x001F6A64 File Offset: 0x001F4C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityMoveCsReq(SceneEntityMoveCsReq other) : this()
		{
			this.pNKNIBLGCLM_ = other.pNKNIBLGCLM_;
			this.entityMotionList_ = other.entityMotionList_.Clone();
			this.entryId_ = other.entryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BAE6 RID: 47846 RVA: 0x001F6AB1 File Offset: 0x001F4CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityMoveCsReq Clone()
		{
			return new SceneEntityMoveCsReq(this);
		}

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x0600BAE7 RID: 47847 RVA: 0x001F6AB9 File Offset: 0x001F4CB9
		// (set) Token: 0x0600BAE8 RID: 47848 RVA: 0x001F6AC1 File Offset: 0x001F4CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong PNKNIBLGCLM
		{
			get
			{
				return this.pNKNIBLGCLM_;
			}
			set
			{
				this.pNKNIBLGCLM_ = value;
			}
		}

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x0600BAE9 RID: 47849 RVA: 0x001F6ACA File Offset: 0x001F4CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityMotion> EntityMotionList
		{
			get
			{
				return this.entityMotionList_;
			}
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x0600BAEA RID: 47850 RVA: 0x001F6AD2 File Offset: 0x001F4CD2
		// (set) Token: 0x0600BAEB RID: 47851 RVA: 0x001F6ADA File Offset: 0x001F4CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntryId
		{
			get
			{
				return this.entryId_;
			}
			set
			{
				this.entryId_ = value;
			}
		}

		// Token: 0x0600BAEC RID: 47852 RVA: 0x001F6AE3 File Offset: 0x001F4CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneEntityMoveCsReq);
		}

		// Token: 0x0600BAED RID: 47853 RVA: 0x001F6AF4 File Offset: 0x001F4CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneEntityMoveCsReq other)
		{
			return other != null && (other == this || (this.PNKNIBLGCLM == other.PNKNIBLGCLM && this.entityMotionList_.Equals(other.entityMotionList_) && this.EntryId == other.EntryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BAEE RID: 47854 RVA: 0x001F6B54 File Offset: 0x001F4D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PNKNIBLGCLM != 0UL)
			{
				num ^= this.PNKNIBLGCLM.GetHashCode();
			}
			num ^= this.entityMotionList_.GetHashCode();
			if (this.EntryId != 0U)
			{
				num ^= this.EntryId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BAEF RID: 47855 RVA: 0x001F6BBA File Offset: 0x001F4DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BAF0 RID: 47856 RVA: 0x001F6BC2 File Offset: 0x001F4DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BAF1 RID: 47857 RVA: 0x001F6BCC File Offset: 0x001F4DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PNKNIBLGCLM != 0UL)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.PNKNIBLGCLM);
			}
			if (this.EntryId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.EntryId);
			}
			this.entityMotionList_.WriteTo(ref output, SceneEntityMoveCsReq._repeated_entityMotionList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BAF2 RID: 47858 RVA: 0x001F6C38 File Offset: 0x001F4E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PNKNIBLGCLM != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.PNKNIBLGCLM);
			}
			num += this.entityMotionList_.CalculateSize(SceneEntityMoveCsReq._repeated_entityMotionList_codec);
			if (this.EntryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntryId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BAF3 RID: 47859 RVA: 0x001F6CA4 File Offset: 0x001F4EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneEntityMoveCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PNKNIBLGCLM != 0UL)
			{
				this.PNKNIBLGCLM = other.PNKNIBLGCLM;
			}
			this.entityMotionList_.Add(other.entityMotionList_);
			if (other.EntryId != 0U)
			{
				this.EntryId = other.EntryId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BAF4 RID: 47860 RVA: 0x001F6D05 File Offset: 0x001F4F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BAF5 RID: 47861 RVA: 0x001F6D10 File Offset: 0x001F4F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 104U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.entityMotionList_.AddEntriesFrom(ref input, SceneEntityMoveCsReq._repeated_entityMotionList_codec);
						}
					}
					else
					{
						this.EntryId = input.ReadUInt32();
					}
				}
				else
				{
					this.PNKNIBLGCLM = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04004BCE RID: 19406
		private static readonly MessageParser<SceneEntityMoveCsReq> _parser = new MessageParser<SceneEntityMoveCsReq>(() => new SceneEntityMoveCsReq());

		// Token: 0x04004BCF RID: 19407
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BD0 RID: 19408
		public const int PNKNIBLGCLMFieldNumber = 3;

		// Token: 0x04004BD1 RID: 19409
		private ulong pNKNIBLGCLM_;

		// Token: 0x04004BD2 RID: 19410
		public const int EntityMotionListFieldNumber = 15;

		// Token: 0x04004BD3 RID: 19411
		private static readonly FieldCodec<EntityMotion> _repeated_entityMotionList_codec = FieldCodec.ForMessage<EntityMotion>(122U, EntityMotion.Parser);

		// Token: 0x04004BD4 RID: 19412
		private readonly RepeatedField<EntityMotion> entityMotionList_ = new RepeatedField<EntityMotion>();

		// Token: 0x04004BD5 RID: 19413
		public const int EntryIdFieldNumber = 13;

		// Token: 0x04004BD6 RID: 19414
		private uint entryId_;
	}
}
