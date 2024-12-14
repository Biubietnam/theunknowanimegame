using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010F5 RID: 4341
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetFriendRemarkNameCsReq : IMessage<SetFriendRemarkNameCsReq>, IMessage, IEquatable<SetFriendRemarkNameCsReq>, IDeepCloneable<SetFriendRemarkNameCsReq>, IBufferMessage
	{
		// Token: 0x1700369C RID: 13980
		// (get) Token: 0x0600C18C RID: 49548 RVA: 0x00208391 File Offset: 0x00206591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetFriendRemarkNameCsReq> Parser
		{
			get
			{
				return SetFriendRemarkNameCsReq._parser;
			}
		}

		// Token: 0x1700369D RID: 13981
		// (get) Token: 0x0600C18D RID: 49549 RVA: 0x00208398 File Offset: 0x00206598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetFriendRemarkNameCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700369E RID: 13982
		// (get) Token: 0x0600C18E RID: 49550 RVA: 0x002083AA File Offset: 0x002065AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFriendRemarkNameCsReq.Descriptor;
			}
		}

		// Token: 0x0600C18F RID: 49551 RVA: 0x002083B1 File Offset: 0x002065B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFriendRemarkNameCsReq()
		{
		}

		// Token: 0x0600C190 RID: 49552 RVA: 0x002083C4 File Offset: 0x002065C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFriendRemarkNameCsReq(SetFriendRemarkNameCsReq other) : this()
		{
			this.uid_ = other.uid_;
			this.remarkName_ = other.remarkName_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C191 RID: 49553 RVA: 0x00208401 File Offset: 0x00206601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFriendRemarkNameCsReq Clone()
		{
			return new SetFriendRemarkNameCsReq(this);
		}

		// Token: 0x1700369F RID: 13983
		// (get) Token: 0x0600C192 RID: 49554 RVA: 0x00208409 File Offset: 0x00206609
		// (set) Token: 0x0600C193 RID: 49555 RVA: 0x00208411 File Offset: 0x00206611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x170036A0 RID: 13984
		// (get) Token: 0x0600C194 RID: 49556 RVA: 0x0020841A File Offset: 0x0020661A
		// (set) Token: 0x0600C195 RID: 49557 RVA: 0x00208422 File Offset: 0x00206622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RemarkName
		{
			get
			{
				return this.remarkName_;
			}
			set
			{
				this.remarkName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036A1 RID: 13985
		// (get) Token: 0x0600C196 RID: 49558 RVA: 0x00208435 File Offset: 0x00206635
		// (set) Token: 0x0600C197 RID: 49559 RVA: 0x0020843D File Offset: 0x0020663D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0600C198 RID: 49560 RVA: 0x00208446 File Offset: 0x00206646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFriendRemarkNameCsReq);
		}

		// Token: 0x0600C199 RID: 49561 RVA: 0x00208454 File Offset: 0x00206654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFriendRemarkNameCsReq other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && !(this.RemarkName != other.RemarkName) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C19A RID: 49562 RVA: 0x002084B4 File Offset: 0x002066B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.RemarkName.Length != 0)
			{
				num ^= this.RemarkName.GetHashCode();
			}
			if (this.Reason != 0U)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C19B RID: 49563 RVA: 0x00208527 File Offset: 0x00206727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C19C RID: 49564 RVA: 0x0020852F File Offset: 0x0020672F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C19D RID: 49565 RVA: 0x00208538 File Offset: 0x00206738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RemarkName.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.RemarkName);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Uid);
			}
			if (this.Reason != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C19E RID: 49566 RVA: 0x002085B4 File Offset: 0x002067B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.RemarkName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RemarkName);
			}
			if (this.Reason != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C19F RID: 49567 RVA: 0x00208628 File Offset: 0x00206828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetFriendRemarkNameCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.RemarkName.Length != 0)
			{
				this.RemarkName = other.RemarkName;
			}
			if (other.Reason != 0U)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C1A0 RID: 49568 RVA: 0x00208691 File Offset: 0x00206891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1A1 RID: 49569 RVA: 0x0020869C File Offset: 0x0020689C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					if (num != 104U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Reason = input.ReadUInt32();
						}
					}
					else
					{
						this.Uid = input.ReadUInt32();
					}
				}
				else
				{
					this.RemarkName = input.ReadString();
				}
			}
		}

		// Token: 0x04004E5F RID: 20063
		private static readonly MessageParser<SetFriendRemarkNameCsReq> _parser = new MessageParser<SetFriendRemarkNameCsReq>(() => new SetFriendRemarkNameCsReq());

		// Token: 0x04004E60 RID: 20064
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E61 RID: 20065
		public const int UidFieldNumber = 13;

		// Token: 0x04004E62 RID: 20066
		private uint uid_;

		// Token: 0x04004E63 RID: 20067
		public const int RemarkNameFieldNumber = 11;

		// Token: 0x04004E64 RID: 20068
		private string remarkName_ = "";

		// Token: 0x04004E65 RID: 20069
		public const int ReasonFieldNumber = 15;

		// Token: 0x04004E66 RID: 20070
		private uint reason_;
	}
}
