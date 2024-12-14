using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DC7 RID: 3527
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReserveStaminaExchangeScRsp : IMessage<ReserveStaminaExchangeScRsp>, IMessage, IEquatable<ReserveStaminaExchangeScRsp>, IDeepCloneable<ReserveStaminaExchangeScRsp>, IBufferMessage
	{
		// Token: 0x17002C87 RID: 11399
		// (get) Token: 0x06009DB2 RID: 40370 RVA: 0x001A41ED File Offset: 0x001A23ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReserveStaminaExchangeScRsp> Parser
		{
			get
			{
				return ReserveStaminaExchangeScRsp._parser;
			}
		}

		// Token: 0x17002C88 RID: 11400
		// (get) Token: 0x06009DB3 RID: 40371 RVA: 0x001A41F4 File Offset: 0x001A23F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReserveStaminaExchangeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C89 RID: 11401
		// (get) Token: 0x06009DB4 RID: 40372 RVA: 0x001A4206 File Offset: 0x001A2406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReserveStaminaExchangeScRsp.Descriptor;
			}
		}

		// Token: 0x06009DB5 RID: 40373 RVA: 0x001A420D File Offset: 0x001A240D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReserveStaminaExchangeScRsp()
		{
		}

		// Token: 0x06009DB6 RID: 40374 RVA: 0x001A4215 File Offset: 0x001A2415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReserveStaminaExchangeScRsp(ReserveStaminaExchangeScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DB7 RID: 40375 RVA: 0x001A4246 File Offset: 0x001A2446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReserveStaminaExchangeScRsp Clone()
		{
			return new ReserveStaminaExchangeScRsp(this);
		}

		// Token: 0x17002C8A RID: 11402
		// (get) Token: 0x06009DB8 RID: 40376 RVA: 0x001A424E File Offset: 0x001A244E
		// (set) Token: 0x06009DB9 RID: 40377 RVA: 0x001A4256 File Offset: 0x001A2456
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

		// Token: 0x17002C8B RID: 11403
		// (get) Token: 0x06009DBA RID: 40378 RVA: 0x001A425F File Offset: 0x001A245F
		// (set) Token: 0x06009DBB RID: 40379 RVA: 0x001A4267 File Offset: 0x001A2467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x06009DBC RID: 40380 RVA: 0x001A4270 File Offset: 0x001A2470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReserveStaminaExchangeScRsp);
		}

		// Token: 0x06009DBD RID: 40381 RVA: 0x001A427E File Offset: 0x001A247E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReserveStaminaExchangeScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009DBE RID: 40382 RVA: 0x001A42BC File Offset: 0x001A24BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Num != 0U)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009DBF RID: 40383 RVA: 0x001A4314 File Offset: 0x001A2514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009DC0 RID: 40384 RVA: 0x001A431C File Offset: 0x001A251C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DC1 RID: 40385 RVA: 0x001A4328 File Offset: 0x001A2528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Num != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009DC2 RID: 40386 RVA: 0x001A4384 File Offset: 0x001A2584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Num != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Num);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009DC3 RID: 40387 RVA: 0x001A43DC File Offset: 0x001A25DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReserveStaminaExchangeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Num != 0U)
			{
				this.Num = other.Num;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009DC4 RID: 40388 RVA: 0x001A442C File Offset: 0x001A262C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DC5 RID: 40389 RVA: 0x001A4438 File Offset: 0x001A2638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Num = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003D52 RID: 15698
		private static readonly MessageParser<ReserveStaminaExchangeScRsp> _parser = new MessageParser<ReserveStaminaExchangeScRsp>(() => new ReserveStaminaExchangeScRsp());

		// Token: 0x04003D53 RID: 15699
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D54 RID: 15700
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04003D55 RID: 15701
		private uint retcode_;

		// Token: 0x04003D56 RID: 15702
		public const int NumFieldNumber = 8;

		// Token: 0x04003D57 RID: 15703
		private uint num_;
	}
}
