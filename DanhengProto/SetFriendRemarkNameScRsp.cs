using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010F7 RID: 4343
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetFriendRemarkNameScRsp : IMessage<SetFriendRemarkNameScRsp>, IMessage, IEquatable<SetFriendRemarkNameScRsp>, IDeepCloneable<SetFriendRemarkNameScRsp>, IBufferMessage
	{
		// Token: 0x170036A3 RID: 13987
		// (get) Token: 0x0600C1A5 RID: 49573 RVA: 0x002087A5 File Offset: 0x002069A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetFriendRemarkNameScRsp> Parser
		{
			get
			{
				return SetFriendRemarkNameScRsp._parser;
			}
		}

		// Token: 0x170036A4 RID: 13988
		// (get) Token: 0x0600C1A6 RID: 49574 RVA: 0x002087AC File Offset: 0x002069AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetFriendRemarkNameScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036A5 RID: 13989
		// (get) Token: 0x0600C1A7 RID: 49575 RVA: 0x002087BE File Offset: 0x002069BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFriendRemarkNameScRsp.Descriptor;
			}
		}

		// Token: 0x0600C1A8 RID: 49576 RVA: 0x002087C5 File Offset: 0x002069C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFriendRemarkNameScRsp()
		{
		}

		// Token: 0x0600C1A9 RID: 49577 RVA: 0x002087D8 File Offset: 0x002069D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFriendRemarkNameScRsp(SetFriendRemarkNameScRsp other) : this()
		{
			this.uid_ = other.uid_;
			this.remarkName_ = other.remarkName_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C1AA RID: 49578 RVA: 0x00208815 File Offset: 0x00206A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFriendRemarkNameScRsp Clone()
		{
			return new SetFriendRemarkNameScRsp(this);
		}

		// Token: 0x170036A6 RID: 13990
		// (get) Token: 0x0600C1AB RID: 49579 RVA: 0x0020881D File Offset: 0x00206A1D
		// (set) Token: 0x0600C1AC RID: 49580 RVA: 0x00208825 File Offset: 0x00206A25
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

		// Token: 0x170036A7 RID: 13991
		// (get) Token: 0x0600C1AD RID: 49581 RVA: 0x0020882E File Offset: 0x00206A2E
		// (set) Token: 0x0600C1AE RID: 49582 RVA: 0x00208836 File Offset: 0x00206A36
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

		// Token: 0x170036A8 RID: 13992
		// (get) Token: 0x0600C1AF RID: 49583 RVA: 0x00208849 File Offset: 0x00206A49
		// (set) Token: 0x0600C1B0 RID: 49584 RVA: 0x00208851 File Offset: 0x00206A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600C1B1 RID: 49585 RVA: 0x0020885A File Offset: 0x00206A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFriendRemarkNameScRsp);
		}

		// Token: 0x0600C1B2 RID: 49586 RVA: 0x00208868 File Offset: 0x00206A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFriendRemarkNameScRsp other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && !(this.RemarkName != other.RemarkName) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C1B3 RID: 49587 RVA: 0x002088C8 File Offset: 0x00206AC8
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
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C1B4 RID: 49588 RVA: 0x0020893B File Offset: 0x00206B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C1B5 RID: 49589 RVA: 0x00208943 File Offset: 0x00206B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C1B6 RID: 49590 RVA: 0x0020894C File Offset: 0x00206B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Uid);
			}
			if (this.RemarkName.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.RemarkName);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C1B7 RID: 49591 RVA: 0x002089C8 File Offset: 0x00206BC8
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
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C1B8 RID: 49592 RVA: 0x00208A3C File Offset: 0x00206C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetFriendRemarkNameScRsp other)
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
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C1B9 RID: 49593 RVA: 0x00208AA5 File Offset: 0x00206CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1BA RID: 49594 RVA: 0x00208AB0 File Offset: 0x00206CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 114U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.RemarkName = input.ReadString();
					}
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E68 RID: 20072
		private static readonly MessageParser<SetFriendRemarkNameScRsp> _parser = new MessageParser<SetFriendRemarkNameScRsp>(() => new SetFriendRemarkNameScRsp());

		// Token: 0x04004E69 RID: 20073
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E6A RID: 20074
		public const int UidFieldNumber = 8;

		// Token: 0x04004E6B RID: 20075
		private uint uid_;

		// Token: 0x04004E6C RID: 20076
		public const int RemarkNameFieldNumber = 14;

		// Token: 0x04004E6D RID: 20077
		private string remarkName_ = "";

		// Token: 0x04004E6E RID: 20078
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04004E6F RID: 20079
		private uint retcode_;
	}
}
