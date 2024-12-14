using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001417 RID: 5143
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class VirtualLineupTrialAvatarChangeScNotify : IMessage<VirtualLineupTrialAvatarChangeScNotify>, IMessage, IEquatable<VirtualLineupTrialAvatarChangeScNotify>, IDeepCloneable<VirtualLineupTrialAvatarChangeScNotify>, IBufferMessage
	{
		// Token: 0x1700406A RID: 16490
		// (get) Token: 0x0600E56E RID: 58734 RVA: 0x0026201F File Offset: 0x0026021F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<VirtualLineupTrialAvatarChangeScNotify> Parser
		{
			get
			{
				return VirtualLineupTrialAvatarChangeScNotify._parser;
			}
		}

		// Token: 0x1700406B RID: 16491
		// (get) Token: 0x0600E56F RID: 58735 RVA: 0x00262026 File Offset: 0x00260226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return VirtualLineupTrialAvatarChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700406C RID: 16492
		// (get) Token: 0x0600E570 RID: 58736 RVA: 0x00262038 File Offset: 0x00260238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VirtualLineupTrialAvatarChangeScNotify.Descriptor;
			}
		}

		// Token: 0x0600E571 RID: 58737 RVA: 0x0026203F File Offset: 0x0026023F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VirtualLineupTrialAvatarChangeScNotify()
		{
		}

		// Token: 0x0600E572 RID: 58738 RVA: 0x00262060 File Offset: 0x00260260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VirtualLineupTrialAvatarChangeScNotify(VirtualLineupTrialAvatarChangeScNotify other) : this()
		{
			this.planeId_ = other.planeId_;
			this.dGOCPFHCLLK_ = other.dGOCPFHCLLK_.Clone();
			this.bEHJDJBCJGO_ = other.bEHJDJBCJGO_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E573 RID: 58739 RVA: 0x002620B2 File Offset: 0x002602B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VirtualLineupTrialAvatarChangeScNotify Clone()
		{
			return new VirtualLineupTrialAvatarChangeScNotify(this);
		}

		// Token: 0x1700406D RID: 16493
		// (get) Token: 0x0600E574 RID: 58740 RVA: 0x002620BA File Offset: 0x002602BA
		// (set) Token: 0x0600E575 RID: 58741 RVA: 0x002620C2 File Offset: 0x002602C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlaneId
		{
			get
			{
				return this.planeId_;
			}
			set
			{
				this.planeId_ = value;
			}
		}

		// Token: 0x1700406E RID: 16494
		// (get) Token: 0x0600E576 RID: 58742 RVA: 0x002620CB File Offset: 0x002602CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DGOCPFHCLLK
		{
			get
			{
				return this.dGOCPFHCLLK_;
			}
		}

		// Token: 0x1700406F RID: 16495
		// (get) Token: 0x0600E577 RID: 58743 RVA: 0x002620D3 File Offset: 0x002602D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BEHJDJBCJGO
		{
			get
			{
				return this.bEHJDJBCJGO_;
			}
		}

		// Token: 0x0600E578 RID: 58744 RVA: 0x002620DB File Offset: 0x002602DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VirtualLineupTrialAvatarChangeScNotify);
		}

		// Token: 0x0600E579 RID: 58745 RVA: 0x002620EC File Offset: 0x002602EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VirtualLineupTrialAvatarChangeScNotify other)
		{
			return other != null && (other == this || (this.PlaneId == other.PlaneId && this.dGOCPFHCLLK_.Equals(other.dGOCPFHCLLK_) && this.bEHJDJBCJGO_.Equals(other.bEHJDJBCJGO_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E57A RID: 58746 RVA: 0x00262150 File Offset: 0x00260350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlaneId != 0U)
			{
				num ^= this.PlaneId.GetHashCode();
			}
			num ^= this.dGOCPFHCLLK_.GetHashCode();
			num ^= this.bEHJDJBCJGO_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E57B RID: 58747 RVA: 0x002621AB File Offset: 0x002603AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E57C RID: 58748 RVA: 0x002621B3 File Offset: 0x002603B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E57D RID: 58749 RVA: 0x002621BC File Offset: 0x002603BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dGOCPFHCLLK_.WriteTo(ref output, VirtualLineupTrialAvatarChangeScNotify._repeated_dGOCPFHCLLK_codec);
			if (this.PlaneId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.PlaneId);
			}
			this.bEHJDJBCJGO_.WriteTo(ref output, VirtualLineupTrialAvatarChangeScNotify._repeated_bEHJDJBCJGO_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E57E RID: 58750 RVA: 0x0026221C File Offset: 0x0026041C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlaneId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlaneId);
			}
			num += this.dGOCPFHCLLK_.CalculateSize(VirtualLineupTrialAvatarChangeScNotify._repeated_dGOCPFHCLLK_codec);
			num += this.bEHJDJBCJGO_.CalculateSize(VirtualLineupTrialAvatarChangeScNotify._repeated_bEHJDJBCJGO_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E57F RID: 58751 RVA: 0x00262280 File Offset: 0x00260480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VirtualLineupTrialAvatarChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlaneId != 0U)
			{
				this.PlaneId = other.PlaneId;
			}
			this.dGOCPFHCLLK_.Add(other.dGOCPFHCLLK_);
			this.bEHJDJBCJGO_.Add(other.bEHJDJBCJGO_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E580 RID: 58752 RVA: 0x002622DE File Offset: 0x002604DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E581 RID: 58753 RVA: 0x002622E8 File Offset: 0x002604E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.dGOCPFHCLLK_.AddEntriesFrom(ref input, VirtualLineupTrialAvatarChangeScNotify._repeated_dGOCPFHCLLK_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.PlaneId = input.ReadUInt32();
						continue;
					}
					if (num == 104U || num == 106U)
					{
						this.bEHJDJBCJGO_.AddEntriesFrom(ref input, VirtualLineupTrialAvatarChangeScNotify._repeated_bEHJDJBCJGO_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005B1C RID: 23324
		private static readonly MessageParser<VirtualLineupTrialAvatarChangeScNotify> _parser = new MessageParser<VirtualLineupTrialAvatarChangeScNotify>(() => new VirtualLineupTrialAvatarChangeScNotify());

		// Token: 0x04005B1D RID: 23325
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B1E RID: 23326
		public const int PlaneIdFieldNumber = 8;

		// Token: 0x04005B1F RID: 23327
		private uint planeId_;

		// Token: 0x04005B20 RID: 23328
		public const int DGOCPFHCLLKFieldNumber = 1;

		// Token: 0x04005B21 RID: 23329
		private static readonly FieldCodec<uint> _repeated_dGOCPFHCLLK_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04005B22 RID: 23330
		private readonly RepeatedField<uint> dGOCPFHCLLK_ = new RepeatedField<uint>();

		// Token: 0x04005B23 RID: 23331
		public const int BEHJDJBCJGOFieldNumber = 13;

		// Token: 0x04005B24 RID: 23332
		private static readonly FieldCodec<uint> _repeated_bEHJDJBCJGO_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04005B25 RID: 23333
		private readonly RepeatedField<uint> bEHJDJBCJGO_ = new RepeatedField<uint>();
	}
}
