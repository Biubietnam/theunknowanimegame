using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001365 RID: 4965
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TrainVisitorInfo : IMessage<TrainVisitorInfo>, IMessage, IEquatable<TrainVisitorInfo>, IDeepCloneable<TrainVisitorInfo>, IBufferMessage
	{
		// Token: 0x17003E37 RID: 15927
		// (get) Token: 0x0600DD86 RID: 56710 RVA: 0x0024DAB3 File Offset: 0x0024BCB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrainVisitorInfo> Parser
		{
			get
			{
				return TrainVisitorInfo._parser;
			}
		}

		// Token: 0x17003E38 RID: 15928
		// (get) Token: 0x0600DD87 RID: 56711 RVA: 0x0024DABA File Offset: 0x0024BCBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TrainVisitorInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E39 RID: 15929
		// (get) Token: 0x0600DD88 RID: 56712 RVA: 0x0024DACC File Offset: 0x0024BCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrainVisitorInfo.Descriptor;
			}
		}

		// Token: 0x0600DD89 RID: 56713 RVA: 0x0024DAD3 File Offset: 0x0024BCD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainVisitorInfo()
		{
		}

		// Token: 0x0600DD8A RID: 56714 RVA: 0x0024DAE8 File Offset: 0x0024BCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainVisitorInfo(TrainVisitorInfo other) : this()
		{
			this.dJLKCHKMNMI_ = other.dJLKCHKMNMI_;
			this.nGOMALGCJNF_ = other.nGOMALGCJNF_;
			this.status_ = other.status_;
			this.eCDLFEANJMA_ = other.eCDLFEANJMA_.Clone();
			this.aBPLNPMNDAD_ = other.aBPLNPMNDAD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD8B RID: 56715 RVA: 0x0024DB4D File Offset: 0x0024BD4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainVisitorInfo Clone()
		{
			return new TrainVisitorInfo(this);
		}

		// Token: 0x17003E3A RID: 15930
		// (get) Token: 0x0600DD8C RID: 56716 RVA: 0x0024DB55 File Offset: 0x0024BD55
		// (set) Token: 0x0600DD8D RID: 56717 RVA: 0x0024DB5D File Offset: 0x0024BD5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DJLKCHKMNMI
		{
			get
			{
				return this.dJLKCHKMNMI_;
			}
			set
			{
				this.dJLKCHKMNMI_ = value;
			}
		}

		// Token: 0x17003E3B RID: 15931
		// (get) Token: 0x0600DD8E RID: 56718 RVA: 0x0024DB66 File Offset: 0x0024BD66
		// (set) Token: 0x0600DD8F RID: 56719 RVA: 0x0024DB6E File Offset: 0x0024BD6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NGOMALGCJNF
		{
			get
			{
				return this.nGOMALGCJNF_;
			}
			set
			{
				this.nGOMALGCJNF_ = value;
			}
		}

		// Token: 0x17003E3C RID: 15932
		// (get) Token: 0x0600DD90 RID: 56720 RVA: 0x0024DB77 File Offset: 0x0024BD77
		// (set) Token: 0x0600DD91 RID: 56721 RVA: 0x0024DB7F File Offset: 0x0024BD7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrainVisitorStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17003E3D RID: 15933
		// (get) Token: 0x0600DD92 RID: 56722 RVA: 0x0024DB88 File Offset: 0x0024BD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ECDLFEANJMA
		{
			get
			{
				return this.eCDLFEANJMA_;
			}
		}

		// Token: 0x17003E3E RID: 15934
		// (get) Token: 0x0600DD93 RID: 56723 RVA: 0x0024DB90 File Offset: 0x0024BD90
		// (set) Token: 0x0600DD94 RID: 56724 RVA: 0x0024DB98 File Offset: 0x0024BD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ABPLNPMNDAD
		{
			get
			{
				return this.aBPLNPMNDAD_;
			}
			set
			{
				this.aBPLNPMNDAD_ = value;
			}
		}

		// Token: 0x0600DD95 RID: 56725 RVA: 0x0024DBA1 File Offset: 0x0024BDA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrainVisitorInfo);
		}

		// Token: 0x0600DD96 RID: 56726 RVA: 0x0024DBB0 File Offset: 0x0024BDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrainVisitorInfo other)
		{
			return other != null && (other == this || (this.DJLKCHKMNMI == other.DJLKCHKMNMI && this.NGOMALGCJNF == other.NGOMALGCJNF && this.Status == other.Status && this.eCDLFEANJMA_.Equals(other.eCDLFEANJMA_) && this.ABPLNPMNDAD == other.ABPLNPMNDAD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD97 RID: 56727 RVA: 0x0024DC30 File Offset: 0x0024BE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DJLKCHKMNMI != 0U)
			{
				num ^= this.DJLKCHKMNMI.GetHashCode();
			}
			if (this.NGOMALGCJNF)
			{
				num ^= this.NGOMALGCJNF.GetHashCode();
			}
			if (this.Status != TrainVisitorStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			num ^= this.eCDLFEANJMA_.GetHashCode();
			if (this.ABPLNPMNDAD != 0U)
			{
				num ^= this.ABPLNPMNDAD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD98 RID: 56728 RVA: 0x0024DCCE File Offset: 0x0024BECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DD99 RID: 56729 RVA: 0x0024DCD6 File Offset: 0x0024BED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD9A RID: 56730 RVA: 0x0024DCE0 File Offset: 0x0024BEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != TrainVisitorStatus.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Status);
			}
			if (this.ABPLNPMNDAD != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ABPLNPMNDAD);
			}
			if (this.DJLKCHKMNMI != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.DJLKCHKMNMI);
			}
			this.eCDLFEANJMA_.WriteTo(ref output, TrainVisitorInfo._repeated_eCDLFEANJMA_codec);
			if (this.NGOMALGCJNF)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.NGOMALGCJNF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD9B RID: 56731 RVA: 0x0024DD84 File Offset: 0x0024BF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DJLKCHKMNMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DJLKCHKMNMI);
			}
			if (this.NGOMALGCJNF)
			{
				num += 2;
			}
			if (this.Status != TrainVisitorStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			num += this.eCDLFEANJMA_.CalculateSize(TrainVisitorInfo._repeated_eCDLFEANJMA_codec);
			if (this.ABPLNPMNDAD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ABPLNPMNDAD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD9C RID: 56732 RVA: 0x0024DE14 File Offset: 0x0024C014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrainVisitorInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DJLKCHKMNMI != 0U)
			{
				this.DJLKCHKMNMI = other.DJLKCHKMNMI;
			}
			if (other.NGOMALGCJNF)
			{
				this.NGOMALGCJNF = other.NGOMALGCJNF;
			}
			if (other.Status != TrainVisitorStatus.None)
			{
				this.Status = other.Status;
			}
			this.eCDLFEANJMA_.Add(other.eCDLFEANJMA_);
			if (other.ABPLNPMNDAD != 0U)
			{
				this.ABPLNPMNDAD = other.ABPLNPMNDAD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD9D RID: 56733 RVA: 0x0024DE9D File Offset: 0x0024C09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD9E RID: 56734 RVA: 0x0024DEA8 File Offset: 0x0024C0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.Status = (TrainVisitorStatus)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.ABPLNPMNDAD = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.DJLKCHKMNMI = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U || num == 58U)
					{
						this.eCDLFEANJMA_.AddEntriesFrom(ref input, TrainVisitorInfo._repeated_eCDLFEANJMA_codec);
						continue;
					}
					if (num == 96U)
					{
						this.NGOMALGCJNF = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005818 RID: 22552
		private static readonly MessageParser<TrainVisitorInfo> _parser = new MessageParser<TrainVisitorInfo>(() => new TrainVisitorInfo());

		// Token: 0x04005819 RID: 22553
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400581A RID: 22554
		public const int DJLKCHKMNMIFieldNumber = 5;

		// Token: 0x0400581B RID: 22555
		private uint dJLKCHKMNMI_;

		// Token: 0x0400581C RID: 22556
		public const int NGOMALGCJNFFieldNumber = 12;

		// Token: 0x0400581D RID: 22557
		private bool nGOMALGCJNF_;

		// Token: 0x0400581E RID: 22558
		public const int StatusFieldNumber = 1;

		// Token: 0x0400581F RID: 22559
		private TrainVisitorStatus status_;

		// Token: 0x04005820 RID: 22560
		public const int ECDLFEANJMAFieldNumber = 7;

		// Token: 0x04005821 RID: 22561
		private static readonly FieldCodec<uint> _repeated_eCDLFEANJMA_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04005822 RID: 22562
		private readonly RepeatedField<uint> eCDLFEANJMA_ = new RepeatedField<uint>();

		// Token: 0x04005823 RID: 22563
		public const int ABPLNPMNDADFieldNumber = 2;

		// Token: 0x04005824 RID: 22564
		private uint aBPLNPMNDAD_;
	}
}
