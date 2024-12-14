using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001213 RID: 4627
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwapLineupScRsp : IMessage<SwapLineupScRsp>, IMessage, IEquatable<SwapLineupScRsp>, IDeepCloneable<SwapLineupScRsp>, IBufferMessage
	{
		// Token: 0x17003A54 RID: 14932
		// (get) Token: 0x0600CED5 RID: 52949 RVA: 0x0022ABD8 File Offset: 0x00228DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwapLineupScRsp> Parser
		{
			get
			{
				return SwapLineupScRsp._parser;
			}
		}

		// Token: 0x17003A55 RID: 14933
		// (get) Token: 0x0600CED6 RID: 52950 RVA: 0x0022ABDF File Offset: 0x00228DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwapLineupScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A56 RID: 14934
		// (get) Token: 0x0600CED7 RID: 52951 RVA: 0x0022ABF1 File Offset: 0x00228DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwapLineupScRsp.Descriptor;
			}
		}

		// Token: 0x0600CED8 RID: 52952 RVA: 0x0022ABF8 File Offset: 0x00228DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwapLineupScRsp()
		{
		}

		// Token: 0x0600CED9 RID: 52953 RVA: 0x0022AC00 File Offset: 0x00228E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwapLineupScRsp(SwapLineupScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CEDA RID: 52954 RVA: 0x0022AC25 File Offset: 0x00228E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwapLineupScRsp Clone()
		{
			return new SwapLineupScRsp(this);
		}

		// Token: 0x17003A57 RID: 14935
		// (get) Token: 0x0600CEDB RID: 52955 RVA: 0x0022AC2D File Offset: 0x00228E2D
		// (set) Token: 0x0600CEDC RID: 52956 RVA: 0x0022AC35 File Offset: 0x00228E35
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

		// Token: 0x0600CEDD RID: 52957 RVA: 0x0022AC3E File Offset: 0x00228E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwapLineupScRsp);
		}

		// Token: 0x0600CEDE RID: 52958 RVA: 0x0022AC4C File Offset: 0x00228E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwapLineupScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CEDF RID: 52959 RVA: 0x0022AC7C File Offset: 0x00228E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600CEE0 RID: 52960 RVA: 0x0022ACBB File Offset: 0x00228EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CEE1 RID: 52961 RVA: 0x0022ACC3 File Offset: 0x00228EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CEE2 RID: 52962 RVA: 0x0022ACCC File Offset: 0x00228ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CEE3 RID: 52963 RVA: 0x0022AD00 File Offset: 0x00228F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600CEE4 RID: 52964 RVA: 0x0022AD3E File Offset: 0x00228F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwapLineupScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CEE5 RID: 52965 RVA: 0x0022AD6F File Offset: 0x00228F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CEE6 RID: 52966 RVA: 0x0022AD78 File Offset: 0x00228F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400534B RID: 21323
		private static readonly MessageParser<SwapLineupScRsp> _parser = new MessageParser<SwapLineupScRsp>(() => new SwapLineupScRsp());

		// Token: 0x0400534C RID: 21324
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400534D RID: 21325
		public const int RetcodeFieldNumber = 1;

		// Token: 0x0400534E RID: 21326
		private uint retcode_;
	}
}
