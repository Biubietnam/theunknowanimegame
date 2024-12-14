using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D3B RID: 3387
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QueryProductInfoScRsp : IMessage<QueryProductInfoScRsp>, IMessage, IEquatable<QueryProductInfoScRsp>, IDeepCloneable<QueryProductInfoScRsp>, IBufferMessage
	{
		// Token: 0x17002ABC RID: 10940
		// (get) Token: 0x0600975F RID: 38751 RVA: 0x001936FF File Offset: 0x001918FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QueryProductInfoScRsp> Parser
		{
			get
			{
				return QueryProductInfoScRsp._parser;
			}
		}

		// Token: 0x17002ABD RID: 10941
		// (get) Token: 0x06009760 RID: 38752 RVA: 0x00193706 File Offset: 0x00191906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QueryProductInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002ABE RID: 10942
		// (get) Token: 0x06009761 RID: 38753 RVA: 0x00193718 File Offset: 0x00191918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryProductInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06009762 RID: 38754 RVA: 0x0019371F File Offset: 0x0019191F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryProductInfoScRsp()
		{
		}

		// Token: 0x06009763 RID: 38755 RVA: 0x00193734 File Offset: 0x00191934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryProductInfoScRsp(QueryProductInfoScRsp other) : this()
		{
			this.dDGDLPFBDAE_ = other.dDGDLPFBDAE_.Clone();
			this.retcode_ = other.retcode_;
			this.eBLHLKGMIAO_ = other.eBLHLKGMIAO_;
			this.gNGOKFEMCMI_ = other.gNGOKFEMCMI_;
			this.kNKJPEKIKOL_ = other.kNKJPEKIKOL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009764 RID: 38756 RVA: 0x00193799 File Offset: 0x00191999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QueryProductInfoScRsp Clone()
		{
			return new QueryProductInfoScRsp(this);
		}

		// Token: 0x17002ABF RID: 10943
		// (get) Token: 0x06009765 RID: 38757 RVA: 0x001937A1 File Offset: 0x001919A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Product> DDGDLPFBDAE
		{
			get
			{
				return this.dDGDLPFBDAE_;
			}
		}

		// Token: 0x17002AC0 RID: 10944
		// (get) Token: 0x06009766 RID: 38758 RVA: 0x001937A9 File Offset: 0x001919A9
		// (set) Token: 0x06009767 RID: 38759 RVA: 0x001937B1 File Offset: 0x001919B1
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

		// Token: 0x17002AC1 RID: 10945
		// (get) Token: 0x06009768 RID: 38760 RVA: 0x001937BA File Offset: 0x001919BA
		// (set) Token: 0x06009769 RID: 38761 RVA: 0x001937C2 File Offset: 0x001919C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EBLHLKGMIAO
		{
			get
			{
				return this.eBLHLKGMIAO_;
			}
			set
			{
				this.eBLHLKGMIAO_ = value;
			}
		}

		// Token: 0x17002AC2 RID: 10946
		// (get) Token: 0x0600976A RID: 38762 RVA: 0x001937CB File Offset: 0x001919CB
		// (set) Token: 0x0600976B RID: 38763 RVA: 0x001937D3 File Offset: 0x001919D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong GNGOKFEMCMI
		{
			get
			{
				return this.gNGOKFEMCMI_;
			}
			set
			{
				this.gNGOKFEMCMI_ = value;
			}
		}

		// Token: 0x17002AC3 RID: 10947
		// (get) Token: 0x0600976C RID: 38764 RVA: 0x001937DC File Offset: 0x001919DC
		// (set) Token: 0x0600976D RID: 38765 RVA: 0x001937E4 File Offset: 0x001919E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KNKJPEKIKOL
		{
			get
			{
				return this.kNKJPEKIKOL_;
			}
			set
			{
				this.kNKJPEKIKOL_ = value;
			}
		}

		// Token: 0x0600976E RID: 38766 RVA: 0x001937ED File Offset: 0x001919ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryProductInfoScRsp);
		}

		// Token: 0x0600976F RID: 38767 RVA: 0x001937FC File Offset: 0x001919FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QueryProductInfoScRsp other)
		{
			return other != null && (other == this || (this.dDGDLPFBDAE_.Equals(other.dDGDLPFBDAE_) && this.Retcode == other.Retcode && this.EBLHLKGMIAO == other.EBLHLKGMIAO && this.GNGOKFEMCMI == other.GNGOKFEMCMI && this.KNKJPEKIKOL == other.KNKJPEKIKOL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009770 RID: 38768 RVA: 0x0019387C File Offset: 0x00191A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dDGDLPFBDAE_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.EBLHLKGMIAO != 0U)
			{
				num ^= this.EBLHLKGMIAO.GetHashCode();
			}
			if (this.GNGOKFEMCMI != 0UL)
			{
				num ^= this.GNGOKFEMCMI.GetHashCode();
			}
			if (this.KNKJPEKIKOL != 0U)
			{
				num ^= this.KNKJPEKIKOL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009771 RID: 38769 RVA: 0x00193914 File Offset: 0x00191B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009772 RID: 38770 RVA: 0x0019391C File Offset: 0x00191B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009773 RID: 38771 RVA: 0x00193928 File Offset: 0x00191B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.GNGOKFEMCMI != 0UL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.GNGOKFEMCMI);
			}
			this.dDGDLPFBDAE_.WriteTo(ref output, QueryProductInfoScRsp._repeated_dDGDLPFBDAE_codec);
			if (this.KNKJPEKIKOL != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.KNKJPEKIKOL);
			}
			if (this.EBLHLKGMIAO != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EBLHLKGMIAO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009774 RID: 38772 RVA: 0x001939CC File Offset: 0x00191BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dDGDLPFBDAE_.CalculateSize(QueryProductInfoScRsp._repeated_dDGDLPFBDAE_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.EBLHLKGMIAO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EBLHLKGMIAO);
			}
			if (this.GNGOKFEMCMI != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GNGOKFEMCMI);
			}
			if (this.KNKJPEKIKOL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KNKJPEKIKOL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009775 RID: 38773 RVA: 0x00193A68 File Offset: 0x00191C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QueryProductInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.dDGDLPFBDAE_.Add(other.dDGDLPFBDAE_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.EBLHLKGMIAO != 0U)
			{
				this.EBLHLKGMIAO = other.EBLHLKGMIAO;
			}
			if (other.GNGOKFEMCMI != 0UL)
			{
				this.GNGOKFEMCMI = other.GNGOKFEMCMI;
			}
			if (other.KNKJPEKIKOL != 0U)
			{
				this.KNKJPEKIKOL = other.KNKJPEKIKOL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009776 RID: 38774 RVA: 0x00193AF1 File Offset: 0x00191CF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009777 RID: 38775 RVA: 0x00193AFC File Offset: 0x00191CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 40U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.GNGOKFEMCMI = input.ReadUInt64();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.dDGDLPFBDAE_.AddEntriesFrom(ref input, QueryProductInfoScRsp._repeated_dDGDLPFBDAE_codec);
						continue;
					}
					if (num == 80U)
					{
						this.KNKJPEKIKOL = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.EBLHLKGMIAO = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003ADB RID: 15067
		private static readonly MessageParser<QueryProductInfoScRsp> _parser = new MessageParser<QueryProductInfoScRsp>(() => new QueryProductInfoScRsp());

		// Token: 0x04003ADC RID: 15068
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003ADD RID: 15069
		public const int DDGDLPFBDAEFieldNumber = 9;

		// Token: 0x04003ADE RID: 15070
		private static readonly FieldCodec<Product> _repeated_dDGDLPFBDAE_codec = FieldCodec.ForMessage<Product>(74U, Product.Parser);

		// Token: 0x04003ADF RID: 15071
		private readonly RepeatedField<Product> dDGDLPFBDAE_ = new RepeatedField<Product>();

		// Token: 0x04003AE0 RID: 15072
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04003AE1 RID: 15073
		private uint retcode_;

		// Token: 0x04003AE2 RID: 15074
		public const int EBLHLKGMIAOFieldNumber = 12;

		// Token: 0x04003AE3 RID: 15075
		private uint eBLHLKGMIAO_;

		// Token: 0x04003AE4 RID: 15076
		public const int GNGOKFEMCMIFieldNumber = 6;

		// Token: 0x04003AE5 RID: 15077
		private ulong gNGOKFEMCMI_;

		// Token: 0x04003AE6 RID: 15078
		public const int KNKJPEKIKOLFieldNumber = 10;

		// Token: 0x04003AE7 RID: 15079
		private uint kNKJPEKIKOL_;
	}
}
