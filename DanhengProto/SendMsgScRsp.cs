using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010BD RID: 4285
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SendMsgScRsp : IMessage<SendMsgScRsp>, IMessage, IEquatable<SendMsgScRsp>, IDeepCloneable<SendMsgScRsp>, IBufferMessage
	{
		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0600BF1A RID: 48922 RVA: 0x00202C98 File Offset: 0x00200E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SendMsgScRsp> Parser
		{
			get
			{
				return SendMsgScRsp._parser;
			}
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0600BF1B RID: 48923 RVA: 0x00202C9F File Offset: 0x00200E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SendMsgScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x0600BF1C RID: 48924 RVA: 0x00202CB1 File Offset: 0x00200EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendMsgScRsp.Descriptor;
			}
		}

		// Token: 0x0600BF1D RID: 48925 RVA: 0x00202CB8 File Offset: 0x00200EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SendMsgScRsp()
		{
		}

		// Token: 0x0600BF1E RID: 48926 RVA: 0x00202CC0 File Offset: 0x00200EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SendMsgScRsp(SendMsgScRsp other) : this()
		{
			this.endTime_ = other.endTime_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF1F RID: 48927 RVA: 0x00202CF1 File Offset: 0x00200EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SendMsgScRsp Clone()
		{
			return new SendMsgScRsp(this);
		}

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x0600BF20 RID: 48928 RVA: 0x00202CF9 File Offset: 0x00200EF9
		// (set) Token: 0x0600BF21 RID: 48929 RVA: 0x00202D01 File Offset: 0x00200F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x170035FE RID: 13822
		// (get) Token: 0x0600BF22 RID: 48930 RVA: 0x00202D0A File Offset: 0x00200F0A
		// (set) Token: 0x0600BF23 RID: 48931 RVA: 0x00202D12 File Offset: 0x00200F12
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

		// Token: 0x0600BF24 RID: 48932 RVA: 0x00202D1B File Offset: 0x00200F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendMsgScRsp);
		}

		// Token: 0x0600BF25 RID: 48933 RVA: 0x00202D29 File Offset: 0x00200F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SendMsgScRsp other)
		{
			return other != null && (other == this || (this.EndTime == other.EndTime && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF26 RID: 48934 RVA: 0x00202D68 File Offset: 0x00200F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EndTime != 0UL)
			{
				num ^= this.EndTime.GetHashCode();
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

		// Token: 0x0600BF27 RID: 48935 RVA: 0x00202DC0 File Offset: 0x00200FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BF28 RID: 48936 RVA: 0x00202DC8 File Offset: 0x00200FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF29 RID: 48937 RVA: 0x00202DD4 File Offset: 0x00200FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.EndTime != 0UL)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF2A RID: 48938 RVA: 0x00202E30 File Offset: 0x00201030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EndTime != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EndTime);
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

		// Token: 0x0600BF2B RID: 48939 RVA: 0x00202E88 File Offset: 0x00201088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SendMsgScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EndTime != 0UL)
			{
				this.EndTime = other.EndTime;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF2C RID: 48940 RVA: 0x00202ED8 File Offset: 0x002010D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF2D RID: 48941 RVA: 0x00202EE4 File Offset: 0x002010E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EndTime = input.ReadUInt64();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004DA1 RID: 19873
		private static readonly MessageParser<SendMsgScRsp> _parser = new MessageParser<SendMsgScRsp>(() => new SendMsgScRsp());

		// Token: 0x04004DA2 RID: 19874
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DA3 RID: 19875
		public const int EndTimeFieldNumber = 11;

		// Token: 0x04004DA4 RID: 19876
		private ulong endTime_;

		// Token: 0x04004DA5 RID: 19877
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04004DA6 RID: 19878
		private uint retcode_;
	}
}
