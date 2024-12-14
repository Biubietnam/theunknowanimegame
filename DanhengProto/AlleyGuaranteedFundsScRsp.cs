using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000089 RID: 137
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlleyGuaranteedFundsScRsp : IMessage<AlleyGuaranteedFundsScRsp>, IMessage, IEquatable<AlleyGuaranteedFundsScRsp>, IDeepCloneable<AlleyGuaranteedFundsScRsp>, IBufferMessage
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x0001072D File Offset: 0x0000E92D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlleyGuaranteedFundsScRsp> Parser
		{
			get
			{
				return AlleyGuaranteedFundsScRsp._parser;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00010734 File Offset: 0x0000E934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AlleyGuaranteedFundsScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00010746 File Offset: 0x0000E946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlleyGuaranteedFundsScRsp.Descriptor;
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0001074D File Offset: 0x0000E94D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyGuaranteedFundsScRsp()
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00010755 File Offset: 0x0000E955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyGuaranteedFundsScRsp(AlleyGuaranteedFundsScRsp other) : this()
		{
			this.pLHCNEGLNLC_ = other.pLHCNEGLNLC_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00010786 File Offset: 0x0000E986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyGuaranteedFundsScRsp Clone()
		{
			return new AlleyGuaranteedFundsScRsp(this);
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x0001078E File Offset: 0x0000E98E
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x00010796 File Offset: 0x0000E996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PLHCNEGLNLC
		{
			get
			{
				return this.pLHCNEGLNLC_;
			}
			set
			{
				this.pLHCNEGLNLC_ = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x0001079F File Offset: 0x0000E99F
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x000107A7 File Offset: 0x0000E9A7
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

		// Token: 0x060005C0 RID: 1472 RVA: 0x000107B0 File Offset: 0x0000E9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlleyGuaranteedFundsScRsp);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000107BE File Offset: 0x0000E9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlleyGuaranteedFundsScRsp other)
		{
			return other != null && (other == this || (this.PLHCNEGLNLC == other.PLHCNEGLNLC && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000107FC File Offset: 0x0000E9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PLHCNEGLNLC != 0U)
			{
				num ^= this.PLHCNEGLNLC.GetHashCode();
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

		// Token: 0x060005C3 RID: 1475 RVA: 0x00010854 File Offset: 0x0000EA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0001085C File Offset: 0x0000EA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00010868 File Offset: 0x0000EA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PLHCNEGLNLC != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PLHCNEGLNLC);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x000108C4 File Offset: 0x0000EAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PLHCNEGLNLC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PLHCNEGLNLC);
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

		// Token: 0x060005C7 RID: 1479 RVA: 0x0001091C File Offset: 0x0000EB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlleyGuaranteedFundsScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PLHCNEGLNLC != 0U)
			{
				this.PLHCNEGLNLC = other.PLHCNEGLNLC;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0001096C File Offset: 0x0000EB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00010978 File Offset: 0x0000EB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 64U)
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
					this.PLHCNEGLNLC = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400021F RID: 543
		private static readonly MessageParser<AlleyGuaranteedFundsScRsp> _parser = new MessageParser<AlleyGuaranteedFundsScRsp>(() => new AlleyGuaranteedFundsScRsp());

		// Token: 0x04000220 RID: 544
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000221 RID: 545
		public const int PLHCNEGLNLCFieldNumber = 2;

		// Token: 0x04000222 RID: 546
		private uint pLHCNEGLNLC_;

		// Token: 0x04000223 RID: 547
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04000224 RID: 548
		private uint retcode_;
	}
}
