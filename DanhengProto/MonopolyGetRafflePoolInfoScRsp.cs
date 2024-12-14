using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B43 RID: 2883
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGetRafflePoolInfoScRsp : IMessage<MonopolyGetRafflePoolInfoScRsp>, IMessage, IEquatable<MonopolyGetRafflePoolInfoScRsp>, IDeepCloneable<MonopolyGetRafflePoolInfoScRsp>, IBufferMessage
	{
		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x06007FA0 RID: 32672 RVA: 0x00151283 File Offset: 0x0014F483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGetRafflePoolInfoScRsp> Parser
		{
			get
			{
				return MonopolyGetRafflePoolInfoScRsp._parser;
			}
		}

		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x06007FA1 RID: 32673 RVA: 0x0015128A File Offset: 0x0014F48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGetRafflePoolInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x06007FA2 RID: 32674 RVA: 0x0015129C File Offset: 0x0014F49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGetRafflePoolInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06007FA3 RID: 32675 RVA: 0x001512A3 File Offset: 0x0014F4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRafflePoolInfoScRsp()
		{
		}

		// Token: 0x06007FA4 RID: 32676 RVA: 0x001512AC File Offset: 0x0014F4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRafflePoolInfoScRsp(MonopolyGetRafflePoolInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.bCNOIFKDEFO_ = ((other.bCNOIFKDEFO_ != null) ? other.bCNOIFKDEFO_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FA5 RID: 32677 RVA: 0x001512F8 File Offset: 0x0014F4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRafflePoolInfoScRsp Clone()
		{
			return new MonopolyGetRafflePoolInfoScRsp(this);
		}

		// Token: 0x170023CD RID: 9165
		// (get) Token: 0x06007FA6 RID: 32678 RVA: 0x00151300 File Offset: 0x0014F500
		// (set) Token: 0x06007FA7 RID: 32679 RVA: 0x00151308 File Offset: 0x0014F508
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

		// Token: 0x170023CE RID: 9166
		// (get) Token: 0x06007FA8 RID: 32680 RVA: 0x00151311 File Offset: 0x0014F511
		// (set) Token: 0x06007FA9 RID: 32681 RVA: 0x00151319 File Offset: 0x0014F519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIPPOBBBBJJ BCNOIFKDEFO
		{
			get
			{
				return this.bCNOIFKDEFO_;
			}
			set
			{
				this.bCNOIFKDEFO_ = value;
			}
		}

		// Token: 0x06007FAA RID: 32682 RVA: 0x00151322 File Offset: 0x0014F522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGetRafflePoolInfoScRsp);
		}

		// Token: 0x06007FAB RID: 32683 RVA: 0x00151330 File Offset: 0x0014F530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGetRafflePoolInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.BCNOIFKDEFO, other.BCNOIFKDEFO) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007FAC RID: 32684 RVA: 0x00151380 File Offset: 0x0014F580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.bCNOIFKDEFO_ != null)
			{
				num ^= this.BCNOIFKDEFO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007FAD RID: 32685 RVA: 0x001513D5 File Offset: 0x0014F5D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007FAE RID: 32686 RVA: 0x001513DD File Offset: 0x0014F5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FAF RID: 32687 RVA: 0x001513E8 File Offset: 0x0014F5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.bCNOIFKDEFO_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.BCNOIFKDEFO);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FB0 RID: 32688 RVA: 0x00151444 File Offset: 0x0014F644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.bCNOIFKDEFO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BCNOIFKDEFO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007FB1 RID: 32689 RVA: 0x0015149C File Offset: 0x0014F69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGetRafflePoolInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.bCNOIFKDEFO_ != null)
			{
				if (this.bCNOIFKDEFO_ == null)
				{
					this.BCNOIFKDEFO = new FIPPOBBBBJJ();
				}
				this.BCNOIFKDEFO.MergeFrom(other.BCNOIFKDEFO);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007FB2 RID: 32690 RVA: 0x00151504 File Offset: 0x0014F704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FB3 RID: 32691 RVA: 0x00151510 File Offset: 0x0014F710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 80U)
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
					if (this.bCNOIFKDEFO_ == null)
					{
						this.BCNOIFKDEFO = new FIPPOBBBBJJ();
					}
					input.ReadMessage(this.BCNOIFKDEFO);
				}
			}
		}

		// Token: 0x040030DF RID: 12511
		private static readonly MessageParser<MonopolyGetRafflePoolInfoScRsp> _parser = new MessageParser<MonopolyGetRafflePoolInfoScRsp>(() => new MonopolyGetRafflePoolInfoScRsp());

		// Token: 0x040030E0 RID: 12512
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030E1 RID: 12513
		public const int RetcodeFieldNumber = 10;

		// Token: 0x040030E2 RID: 12514
		private uint retcode_;

		// Token: 0x040030E3 RID: 12515
		public const int BCNOIFKDEFOFieldNumber = 9;

		// Token: 0x040030E4 RID: 12516
		private FIPPOBBBBJJ bCNOIFKDEFO_;
	}
}
