using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001027 RID: 4135
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournWorkbenchInfo : IMessage<RogueTournWorkbenchInfo>, IMessage, IEquatable<RogueTournWorkbenchInfo>, IDeepCloneable<RogueTournWorkbenchInfo>, IBufferMessage
	{
		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x0600B7E2 RID: 47074 RVA: 0x001ED677 File Offset: 0x001EB877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournWorkbenchInfo> Parser
		{
			get
			{
				return RogueTournWorkbenchInfo._parser;
			}
		}

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0600B7E3 RID: 47075 RVA: 0x001ED67E File Offset: 0x001EB87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournWorkbenchInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0600B7E4 RID: 47076 RVA: 0x001ED690 File Offset: 0x001EB890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournWorkbenchInfo.Descriptor;
			}
		}

		// Token: 0x0600B7E5 RID: 47077 RVA: 0x001ED697 File Offset: 0x001EB897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournWorkbenchInfo()
		{
		}

		// Token: 0x0600B7E6 RID: 47078 RVA: 0x001ED6AA File Offset: 0x001EB8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournWorkbenchInfo(RogueTournWorkbenchInfo other) : this()
		{
			this.workbenchId_ = other.workbenchId_;
			this.workbenchFuncList_ = other.workbenchFuncList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B7E7 RID: 47079 RVA: 0x001ED6E0 File Offset: 0x001EB8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournWorkbenchInfo Clone()
		{
			return new RogueTournWorkbenchInfo(this);
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0600B7E8 RID: 47080 RVA: 0x001ED6E8 File Offset: 0x001EB8E8
		// (set) Token: 0x0600B7E9 RID: 47081 RVA: 0x001ED6F0 File Offset: 0x001EB8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorkbenchId
		{
			get
			{
				return this.workbenchId_;
			}
			set
			{
				this.workbenchId_ = value;
			}
		}

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x0600B7EA RID: 47082 RVA: 0x001ED6F9 File Offset: 0x001EB8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WorkbenchFuncIdInfo> WorkbenchFuncList
		{
			get
			{
				return this.workbenchFuncList_;
			}
		}

		// Token: 0x0600B7EB RID: 47083 RVA: 0x001ED701 File Offset: 0x001EB901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournWorkbenchInfo);
		}

		// Token: 0x0600B7EC RID: 47084 RVA: 0x001ED710 File Offset: 0x001EB910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournWorkbenchInfo other)
		{
			return other != null && (other == this || (this.WorkbenchId == other.WorkbenchId && this.workbenchFuncList_.Equals(other.workbenchFuncList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B7ED RID: 47085 RVA: 0x001ED760 File Offset: 0x001EB960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WorkbenchId != 0U)
			{
				num ^= this.WorkbenchId.GetHashCode();
			}
			num ^= this.workbenchFuncList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B7EE RID: 47086 RVA: 0x001ED7AD File Offset: 0x001EB9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B7EF RID: 47087 RVA: 0x001ED7B5 File Offset: 0x001EB9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B7F0 RID: 47088 RVA: 0x001ED7C0 File Offset: 0x001EB9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.workbenchFuncList_.WriteTo(ref output, RogueTournWorkbenchInfo._repeated_workbenchFuncList_codec);
			if (this.WorkbenchId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.WorkbenchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B7F1 RID: 47089 RVA: 0x001ED810 File Offset: 0x001EBA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WorkbenchId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorkbenchId);
			}
			num += this.workbenchFuncList_.CalculateSize(RogueTournWorkbenchInfo._repeated_workbenchFuncList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B7F2 RID: 47090 RVA: 0x001ED864 File Offset: 0x001EBA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournWorkbenchInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WorkbenchId != 0U)
			{
				this.WorkbenchId = other.WorkbenchId;
			}
			this.workbenchFuncList_.Add(other.workbenchFuncList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B7F3 RID: 47091 RVA: 0x001ED8B1 File Offset: 0x001EBAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B7F4 RID: 47092 RVA: 0x001ED8BC File Offset: 0x001EBABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.WorkbenchId = input.ReadUInt32();
					}
				}
				else
				{
					this.workbenchFuncList_.AddEntriesFrom(ref input, RogueTournWorkbenchInfo._repeated_workbenchFuncList_codec);
				}
			}
		}

		// Token: 0x04004A7C RID: 19068
		private static readonly MessageParser<RogueTournWorkbenchInfo> _parser = new MessageParser<RogueTournWorkbenchInfo>(() => new RogueTournWorkbenchInfo());

		// Token: 0x04004A7D RID: 19069
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A7E RID: 19070
		public const int WorkbenchIdFieldNumber = 15;

		// Token: 0x04004A7F RID: 19071
		private uint workbenchId_;

		// Token: 0x04004A80 RID: 19072
		public const int WorkbenchFuncListFieldNumber = 6;

		// Token: 0x04004A81 RID: 19073
		private static readonly FieldCodec<WorkbenchFuncIdInfo> _repeated_workbenchFuncList_codec = FieldCodec.ForMessage<WorkbenchFuncIdInfo>(50U, WorkbenchFuncIdInfo.Parser);

		// Token: 0x04004A82 RID: 19074
		private readonly RepeatedField<WorkbenchFuncIdInfo> workbenchFuncList_ = new RepeatedField<WorkbenchFuncIdInfo>();
	}
}
