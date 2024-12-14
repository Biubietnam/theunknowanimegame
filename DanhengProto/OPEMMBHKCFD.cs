using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C69 RID: 3177
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OPEMMBHKCFD : IMessage<OPEMMBHKCFD>, IMessage, IEquatable<OPEMMBHKCFD>, IDeepCloneable<OPEMMBHKCFD>, IBufferMessage
	{
		// Token: 0x170027A6 RID: 10150
		// (get) Token: 0x06008D26 RID: 36134 RVA: 0x00175147 File Offset: 0x00173347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OPEMMBHKCFD> Parser
		{
			get
			{
				return OPEMMBHKCFD._parser;
			}
		}

		// Token: 0x170027A7 RID: 10151
		// (get) Token: 0x06008D27 RID: 36135 RVA: 0x0017514E File Offset: 0x0017334E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OPEMMBHKCFDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027A8 RID: 10152
		// (get) Token: 0x06008D28 RID: 36136 RVA: 0x00175160 File Offset: 0x00173360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OPEMMBHKCFD.Descriptor;
			}
		}

		// Token: 0x06008D29 RID: 36137 RVA: 0x00175167 File Offset: 0x00173367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OPEMMBHKCFD()
		{
		}

		// Token: 0x06008D2A RID: 36138 RVA: 0x0017517C File Offset: 0x0017337C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OPEMMBHKCFD(OPEMMBHKCFD other) : this()
		{
			this.iBAJGALJKHJ_ = other.iBAJGALJKHJ_;
			this.dBMFHIMKNCC_ = other.dBMFHIMKNCC_;
			this.eventId_ = other.eventId_;
			this.iDMAMIMFCPG_ = other.iDMAMIMFCPG_;
			this.dPAAMCBCKDA_ = other.dPAAMCBCKDA_.Clone();
			this.state_ = other.state_;
			this.aPOELPDBOHG_ = other.aPOELPDBOHG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D2B RID: 36139 RVA: 0x001751F9 File Offset: 0x001733F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OPEMMBHKCFD Clone()
		{
			return new OPEMMBHKCFD(this);
		}

		// Token: 0x170027A9 RID: 10153
		// (get) Token: 0x06008D2C RID: 36140 RVA: 0x00175201 File Offset: 0x00173401
		// (set) Token: 0x06008D2D RID: 36141 RVA: 0x00175209 File Offset: 0x00173409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IBAJGALJKHJ
		{
			get
			{
				return this.iBAJGALJKHJ_;
			}
			set
			{
				this.iBAJGALJKHJ_ = value;
			}
		}

		// Token: 0x170027AA RID: 10154
		// (get) Token: 0x06008D2E RID: 36142 RVA: 0x00175212 File Offset: 0x00173412
		// (set) Token: 0x06008D2F RID: 36143 RVA: 0x0017521A File Offset: 0x0017341A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DBMFHIMKNCC
		{
			get
			{
				return this.dBMFHIMKNCC_;
			}
			set
			{
				this.dBMFHIMKNCC_ = value;
			}
		}

		// Token: 0x170027AB RID: 10155
		// (get) Token: 0x06008D30 RID: 36144 RVA: 0x00175223 File Offset: 0x00173423
		// (set) Token: 0x06008D31 RID: 36145 RVA: 0x0017522B File Offset: 0x0017342B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x170027AC RID: 10156
		// (get) Token: 0x06008D32 RID: 36146 RVA: 0x00175234 File Offset: 0x00173434
		// (set) Token: 0x06008D33 RID: 36147 RVA: 0x0017523C File Offset: 0x0017343C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IDMAMIMFCPG
		{
			get
			{
				return this.iDMAMIMFCPG_;
			}
			set
			{
				this.iDMAMIMFCPG_ = value;
			}
		}

		// Token: 0x170027AD RID: 10157
		// (get) Token: 0x06008D34 RID: 36148 RVA: 0x00175245 File Offset: 0x00173445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DPAAMCBCKDA
		{
			get
			{
				return this.dPAAMCBCKDA_;
			}
		}

		// Token: 0x170027AE RID: 10158
		// (get) Token: 0x06008D35 RID: 36149 RVA: 0x0017524D File Offset: 0x0017344D
		// (set) Token: 0x06008D36 RID: 36150 RVA: 0x00175255 File Offset: 0x00173455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumRandomEventState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x170027AF RID: 10159
		// (get) Token: 0x06008D37 RID: 36151 RVA: 0x0017525E File Offset: 0x0017345E
		// (set) Token: 0x06008D38 RID: 36152 RVA: 0x00175266 File Offset: 0x00173466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint APOELPDBOHG
		{
			get
			{
				return this.aPOELPDBOHG_;
			}
			set
			{
				this.aPOELPDBOHG_ = value;
			}
		}

		// Token: 0x06008D39 RID: 36153 RVA: 0x0017526F File Offset: 0x0017346F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OPEMMBHKCFD);
		}

		// Token: 0x06008D3A RID: 36154 RVA: 0x00175280 File Offset: 0x00173480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OPEMMBHKCFD other)
		{
			return other != null && (other == this || (this.IBAJGALJKHJ == other.IBAJGALJKHJ && this.DBMFHIMKNCC == other.DBMFHIMKNCC && this.EventId == other.EventId && this.IDMAMIMFCPG == other.IDMAMIMFCPG && this.dPAAMCBCKDA_.Equals(other.dPAAMCBCKDA_) && this.State == other.State && this.APOELPDBOHG == other.APOELPDBOHG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D3B RID: 36155 RVA: 0x00175320 File Offset: 0x00173520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IBAJGALJKHJ != 0U)
			{
				num ^= this.IBAJGALJKHJ.GetHashCode();
			}
			if (this.DBMFHIMKNCC != 0U)
			{
				num ^= this.DBMFHIMKNCC.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.IDMAMIMFCPG != 0U)
			{
				num ^= this.IDMAMIMFCPG.GetHashCode();
			}
			num ^= this.dPAAMCBCKDA_.GetHashCode();
			if (this.State != MuseumRandomEventState.None)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.APOELPDBOHG != 0U)
			{
				num ^= this.APOELPDBOHG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D3C RID: 36156 RVA: 0x001753F0 File Offset: 0x001735F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008D3D RID: 36157 RVA: 0x001753F8 File Offset: 0x001735F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D3E RID: 36158 RVA: 0x00175404 File Offset: 0x00173604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dPAAMCBCKDA_.WriteTo(ref output, OPEMMBHKCFD._repeated_dPAAMCBCKDA_codec);
			if (this.State != MuseumRandomEventState.None)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.State);
			}
			if (this.IBAJGALJKHJ != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.IBAJGALJKHJ);
			}
			if (this.EventId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.EventId);
			}
			if (this.DBMFHIMKNCC != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.DBMFHIMKNCC);
			}
			if (this.IDMAMIMFCPG != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.IDMAMIMFCPG);
			}
			if (this.APOELPDBOHG != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.APOELPDBOHG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D3F RID: 36159 RVA: 0x001754E0 File Offset: 0x001736E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IBAJGALJKHJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IBAJGALJKHJ);
			}
			if (this.DBMFHIMKNCC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DBMFHIMKNCC);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this.IDMAMIMFCPG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IDMAMIMFCPG);
			}
			num += this.dPAAMCBCKDA_.CalculateSize(OPEMMBHKCFD._repeated_dPAAMCBCKDA_codec);
			if (this.State != MuseumRandomEventState.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.APOELPDBOHG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.APOELPDBOHG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D40 RID: 36160 RVA: 0x001755AC File Offset: 0x001737AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OPEMMBHKCFD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IBAJGALJKHJ != 0U)
			{
				this.IBAJGALJKHJ = other.IBAJGALJKHJ;
			}
			if (other.DBMFHIMKNCC != 0U)
			{
				this.DBMFHIMKNCC = other.DBMFHIMKNCC;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			if (other.IDMAMIMFCPG != 0U)
			{
				this.IDMAMIMFCPG = other.IDMAMIMFCPG;
			}
			this.dPAAMCBCKDA_.Add(other.dPAAMCBCKDA_);
			if (other.State != MuseumRandomEventState.None)
			{
				this.State = other.State;
			}
			if (other.APOELPDBOHG != 0U)
			{
				this.APOELPDBOHG = other.APOELPDBOHG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008D41 RID: 36161 RVA: 0x0017565D File Offset: 0x0017385D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D42 RID: 36162 RVA: 0x00175668 File Offset: 0x00173868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.dPAAMCBCKDA_.AddEntriesFrom(ref input, OPEMMBHKCFD._repeated_dPAAMCBCKDA_codec);
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.State = (MuseumRandomEventState)input.ReadEnum();
							continue;
						}
						if (num == 48U)
						{
							this.IBAJGALJKHJ = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 72U)
					{
						this.EventId = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.DBMFHIMKNCC = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.IDMAMIMFCPG = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.APOELPDBOHG = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003634 RID: 13876
		private static readonly MessageParser<OPEMMBHKCFD> _parser = new MessageParser<OPEMMBHKCFD>(() => new OPEMMBHKCFD());

		// Token: 0x04003635 RID: 13877
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003636 RID: 13878
		public const int IBAJGALJKHJFieldNumber = 6;

		// Token: 0x04003637 RID: 13879
		private uint iBAJGALJKHJ_;

		// Token: 0x04003638 RID: 13880
		public const int DBMFHIMKNCCFieldNumber = 11;

		// Token: 0x04003639 RID: 13881
		private uint dBMFHIMKNCC_;

		// Token: 0x0400363A RID: 13882
		public const int EventIdFieldNumber = 9;

		// Token: 0x0400363B RID: 13883
		private uint eventId_;

		// Token: 0x0400363C RID: 13884
		public const int IDMAMIMFCPGFieldNumber = 12;

		// Token: 0x0400363D RID: 13885
		private uint iDMAMIMFCPG_;

		// Token: 0x0400363E RID: 13886
		public const int DPAAMCBCKDAFieldNumber = 1;

		// Token: 0x0400363F RID: 13887
		private static readonly FieldCodec<uint> _repeated_dPAAMCBCKDA_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04003640 RID: 13888
		private readonly RepeatedField<uint> dPAAMCBCKDA_ = new RepeatedField<uint>();

		// Token: 0x04003641 RID: 13889
		public const int StateFieldNumber = 4;

		// Token: 0x04003642 RID: 13890
		private MuseumRandomEventState state_;

		// Token: 0x04003643 RID: 13891
		public const int APOELPDBOHGFieldNumber = 15;

		// Token: 0x04003644 RID: 13892
		private uint aPOELPDBOHG_;
	}
}
