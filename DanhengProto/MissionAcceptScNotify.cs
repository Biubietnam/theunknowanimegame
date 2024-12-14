using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AD9 RID: 2777
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MissionAcceptScNotify : IMessage<MissionAcceptScNotify>, IMessage, IEquatable<MissionAcceptScNotify>, IDeepCloneable<MissionAcceptScNotify>, IBufferMessage
	{
		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x06007B07 RID: 31495 RVA: 0x00145BA0 File Offset: 0x00143DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MissionAcceptScNotify> Parser
		{
			get
			{
				return MissionAcceptScNotify._parser;
			}
		}

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x06007B08 RID: 31496 RVA: 0x00145BA7 File Offset: 0x00143DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MissionAcceptScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x06007B09 RID: 31497 RVA: 0x00145BB9 File Offset: 0x00143DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MissionAcceptScNotify.Descriptor;
			}
		}

		// Token: 0x06007B0A RID: 31498 RVA: 0x00145BC0 File Offset: 0x00143DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionAcceptScNotify()
		{
		}

		// Token: 0x06007B0B RID: 31499 RVA: 0x00145BD3 File Offset: 0x00143DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionAcceptScNotify(MissionAcceptScNotify other) : this()
		{
			this.subMissionIdList_ = other.subMissionIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B0C RID: 31500 RVA: 0x00145BFD File Offset: 0x00143DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionAcceptScNotify Clone()
		{
			return new MissionAcceptScNotify(this);
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x06007B0D RID: 31501 RVA: 0x00145C05 File Offset: 0x00143E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SubMissionIdList
		{
			get
			{
				return this.subMissionIdList_;
			}
		}

		// Token: 0x06007B0E RID: 31502 RVA: 0x00145C0D File Offset: 0x00143E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MissionAcceptScNotify);
		}

		// Token: 0x06007B0F RID: 31503 RVA: 0x00145C1B File Offset: 0x00143E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MissionAcceptScNotify other)
		{
			return other != null && (other == this || (this.subMissionIdList_.Equals(other.subMissionIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B10 RID: 31504 RVA: 0x00145C50 File Offset: 0x00143E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.subMissionIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B11 RID: 31505 RVA: 0x00145C84 File Offset: 0x00143E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007B12 RID: 31506 RVA: 0x00145C8C File Offset: 0x00143E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B13 RID: 31507 RVA: 0x00145C95 File Offset: 0x00143E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.subMissionIdList_.WriteTo(ref output, MissionAcceptScNotify._repeated_subMissionIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B14 RID: 31508 RVA: 0x00145CBC File Offset: 0x00143EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.subMissionIdList_.CalculateSize(MissionAcceptScNotify._repeated_subMissionIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B15 RID: 31509 RVA: 0x00145CF5 File Offset: 0x00143EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MissionAcceptScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.subMissionIdList_.Add(other.subMissionIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B16 RID: 31510 RVA: 0x00145D23 File Offset: 0x00143F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B17 RID: 31511 RVA: 0x00145D2C File Offset: 0x00143F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.subMissionIdList_.AddEntriesFrom(ref input, MissionAcceptScNotify._repeated_subMissionIdList_codec);
				}
			}
		}

		// Token: 0x04002F34 RID: 12084
		private static readonly MessageParser<MissionAcceptScNotify> _parser = new MessageParser<MissionAcceptScNotify>(() => new MissionAcceptScNotify());

		// Token: 0x04002F35 RID: 12085
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F36 RID: 12086
		public const int SubMissionIdListFieldNumber = 12;

		// Token: 0x04002F37 RID: 12087
		private static readonly FieldCodec<uint> _repeated_subMissionIdList_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x04002F38 RID: 12088
		private readonly RepeatedField<uint> subMissionIdList_ = new RepeatedField<uint>();
	}
}
