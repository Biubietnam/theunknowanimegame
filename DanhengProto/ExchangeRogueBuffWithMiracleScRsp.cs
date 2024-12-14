using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004DD RID: 1245
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeRogueBuffWithMiracleScRsp : IMessage<ExchangeRogueBuffWithMiracleScRsp>, IMessage, IEquatable<ExchangeRogueBuffWithMiracleScRsp>, IDeepCloneable<ExchangeRogueBuffWithMiracleScRsp>, IBufferMessage
	{
		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x060037AD RID: 14253 RVA: 0x00098B33 File Offset: 0x00096D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeRogueBuffWithMiracleScRsp> Parser
		{
			get
			{
				return ExchangeRogueBuffWithMiracleScRsp._parser;
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x060037AE RID: 14254 RVA: 0x00098B3A File Offset: 0x00096D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExchangeRogueBuffWithMiracleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x060037AF RID: 14255 RVA: 0x00098B4C File Offset: 0x00096D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeRogueBuffWithMiracleScRsp.Descriptor;
			}
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x00098B53 File Offset: 0x00096D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRogueBuffWithMiracleScRsp()
		{
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x00098B5C File Offset: 0x00096D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRogueBuffWithMiracleScRsp(ExchangeRogueBuffWithMiracleScRsp other) : this()
		{
			this.buff_ = ((other.buff_ != null) ? other.buff_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x00098BA8 File Offset: 0x00096DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRogueBuffWithMiracleScRsp Clone()
		{
			return new ExchangeRogueBuffWithMiracleScRsp(this);
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x060037B3 RID: 14259 RVA: 0x00098BB0 File Offset: 0x00096DB0
		// (set) Token: 0x060037B4 RID: 14260 RVA: 0x00098BB8 File Offset: 0x00096DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuff Buff
		{
			get
			{
				return this.buff_;
			}
			set
			{
				this.buff_ = value;
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x060037B5 RID: 14261 RVA: 0x00098BC1 File Offset: 0x00096DC1
		// (set) Token: 0x060037B6 RID: 14262 RVA: 0x00098BC9 File Offset: 0x00096DC9
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

		// Token: 0x060037B7 RID: 14263 RVA: 0x00098BD2 File Offset: 0x00096DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeRogueBuffWithMiracleScRsp);
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x00098BE0 File Offset: 0x00096DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeRogueBuffWithMiracleScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Buff, other.Buff) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x00098C30 File Offset: 0x00096E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.buff_ != null)
			{
				num ^= this.Buff.GetHashCode();
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

		// Token: 0x060037BA RID: 14266 RVA: 0x00098C85 File Offset: 0x00096E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x00098C8D File Offset: 0x00096E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x00098C98 File Offset: 0x00096E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.buff_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Buff);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x00098CF4 File Offset: 0x00096EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.buff_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Buff);
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

		// Token: 0x060037BE RID: 14270 RVA: 0x00098D4C File Offset: 0x00096F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeRogueBuffWithMiracleScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.buff_ != null)
			{
				if (this.buff_ == null)
				{
					this.Buff = new RogueCommonBuff();
				}
				this.Buff.MergeFrom(other.Buff);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x00098DB4 File Offset: 0x00096FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00098DC0 File Offset: 0x00096FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.buff_ == null)
						{
							this.Buff = new RogueCommonBuff();
						}
						input.ReadMessage(this.Buff);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400160C RID: 5644
		private static readonly MessageParser<ExchangeRogueBuffWithMiracleScRsp> _parser = new MessageParser<ExchangeRogueBuffWithMiracleScRsp>(() => new ExchangeRogueBuffWithMiracleScRsp());

		// Token: 0x0400160D RID: 5645
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400160E RID: 5646
		public const int BuffFieldNumber = 14;

		// Token: 0x0400160F RID: 5647
		private RogueCommonBuff buff_;

		// Token: 0x04001610 RID: 5648
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04001611 RID: 5649
		private uint retcode_;
	}
}
