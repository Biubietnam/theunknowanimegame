using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000177 RID: 375
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CellAdvanceInfo : IMessage<CellAdvanceInfo>, IMessage, IEquatable<CellAdvanceInfo>, IDeepCloneable<CellAdvanceInfo>, IBufferMessage
	{
		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x00030497 File Offset: 0x0002E697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CellAdvanceInfo> Parser
		{
			get
			{
				return CellAdvanceInfo._parser;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x0003049E File Offset: 0x0002E69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CellAdvanceInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x000304B0 File Offset: 0x0002E6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CellAdvanceInfo.Descriptor;
			}
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x000304B7 File Offset: 0x0002E6B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellAdvanceInfo()
		{
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x000304C0 File Offset: 0x0002E6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellAdvanceInfo(CellAdvanceInfo other) : this()
		{
			this.cellBossInfo_ = ((other.cellBossInfo_ != null) ? other.cellBossInfo_.Clone() : null);
			this.selectBossInfo_ = ((other.selectBossInfo_ != null) ? other.selectBossInfo_.Clone() : null);
			this.finalBossInfo_ = ((other.finalBossInfo_ != null) ? other.finalBossInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00030538 File Offset: 0x0002E738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellAdvanceInfo Clone()
		{
			return new CellAdvanceInfo(this);
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x00030540 File Offset: 0x0002E740
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x00030548 File Offset: 0x0002E748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellMonsterInfo CellBossInfo
		{
			get
			{
				return this.cellBossInfo_;
			}
			set
			{
				this.cellBossInfo_ = value;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x00030551 File Offset: 0x0002E751
		// (set) Token: 0x060010C0 RID: 4288 RVA: 0x00030559 File Offset: 0x0002E759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellMonsterSelectInfo SelectBossInfo
		{
			get
			{
				return this.selectBossInfo_;
			}
			set
			{
				this.selectBossInfo_ = value;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00030562 File Offset: 0x0002E762
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x0003056A File Offset: 0x0002E76A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CellFinalMonsterInfo FinalBossInfo
		{
			get
			{
				return this.finalBossInfo_;
			}
			set
			{
				this.finalBossInfo_ = value;
			}
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00030573 File Offset: 0x0002E773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CellAdvanceInfo);
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00030584 File Offset: 0x0002E784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CellAdvanceInfo other)
		{
			return other != null && (other == this || (object.Equals(this.CellBossInfo, other.CellBossInfo) && object.Equals(this.SelectBossInfo, other.SelectBossInfo) && object.Equals(this.FinalBossInfo, other.FinalBossInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x000305EC File Offset: 0x0002E7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.cellBossInfo_ != null)
			{
				num ^= this.CellBossInfo.GetHashCode();
			}
			if (this.selectBossInfo_ != null)
			{
				num ^= this.SelectBossInfo.GetHashCode();
			}
			if (this.finalBossInfo_ != null)
			{
				num ^= this.FinalBossInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00030654 File Offset: 0x0002E854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0003065C File Offset: 0x0002E85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00030668 File Offset: 0x0002E868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.finalBossInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.FinalBossInfo);
			}
			if (this.cellBossInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.CellBossInfo);
			}
			if (this.selectBossInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.SelectBossInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x000306E0 File Offset: 0x0002E8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.cellBossInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CellBossInfo);
			}
			if (this.selectBossInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelectBossInfo);
			}
			if (this.finalBossInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FinalBossInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00030750 File Offset: 0x0002E950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CellAdvanceInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.cellBossInfo_ != null)
			{
				if (this.cellBossInfo_ == null)
				{
					this.CellBossInfo = new CellMonsterInfo();
				}
				this.CellBossInfo.MergeFrom(other.CellBossInfo);
			}
			if (other.selectBossInfo_ != null)
			{
				if (this.selectBossInfo_ == null)
				{
					this.SelectBossInfo = new CellMonsterSelectInfo();
				}
				this.SelectBossInfo.MergeFrom(other.SelectBossInfo);
			}
			if (other.finalBossInfo_ != null)
			{
				if (this.finalBossInfo_ == null)
				{
					this.FinalBossInfo = new CellFinalMonsterInfo();
				}
				this.FinalBossInfo.MergeFrom(other.FinalBossInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x000307FC File Offset: 0x0002E9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00030808 File Offset: 0x0002EA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					if (num != 90U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.selectBossInfo_ == null)
							{
								this.SelectBossInfo = new CellMonsterSelectInfo();
							}
							input.ReadMessage(this.SelectBossInfo);
						}
					}
					else
					{
						if (this.cellBossInfo_ == null)
						{
							this.CellBossInfo = new CellMonsterInfo();
						}
						input.ReadMessage(this.CellBossInfo);
					}
				}
				else
				{
					if (this.finalBossInfo_ == null)
					{
						this.FinalBossInfo = new CellFinalMonsterInfo();
					}
					input.ReadMessage(this.FinalBossInfo);
				}
			}
		}

		// Token: 0x04000701 RID: 1793
		private static readonly MessageParser<CellAdvanceInfo> _parser = new MessageParser<CellAdvanceInfo>(() => new CellAdvanceInfo());

		// Token: 0x04000702 RID: 1794
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000703 RID: 1795
		public const int CellBossInfoFieldNumber = 11;

		// Token: 0x04000704 RID: 1796
		private CellMonsterInfo cellBossInfo_;

		// Token: 0x04000705 RID: 1797
		public const int SelectBossInfoFieldNumber = 14;

		// Token: 0x04000706 RID: 1798
		private CellMonsterSelectInfo selectBossInfo_;

		// Token: 0x04000707 RID: 1799
		public const int FinalBossInfoFieldNumber = 8;

		// Token: 0x04000708 RID: 1800
		private CellFinalMonsterInfo finalBossInfo_;
	}
}
