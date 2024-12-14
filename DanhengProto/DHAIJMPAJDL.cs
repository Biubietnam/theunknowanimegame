using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000395 RID: 917
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DHAIJMPAJDL : IMessage<DHAIJMPAJDL>, IMessage, IEquatable<DHAIJMPAJDL>, IDeepCloneable<DHAIJMPAJDL>, IBufferMessage
	{
		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x000713F7 File Offset: 0x0006F5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DHAIJMPAJDL> Parser
		{
			get
			{
				return DHAIJMPAJDL._parser;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x060028B8 RID: 10424 RVA: 0x000713FE File Offset: 0x0006F5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DHAIJMPAJDLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x00071410 File Offset: 0x0006F610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DHAIJMPAJDL.Descriptor;
			}
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x00071417 File Offset: 0x0006F617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DHAIJMPAJDL()
		{
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x00071420 File Offset: 0x0006F620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DHAIJMPAJDL(DHAIJMPAJDL other) : this()
		{
			this.mapId_ = other.mapId_;
			this.cellId_ = other.cellId_;
			this.bFEKIKBIMCG_ = other.bFEKIKBIMCG_;
			this.pMPFMFNKNGJ_ = other.pMPFMFNKNGJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x00071474 File Offset: 0x0006F674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DHAIJMPAJDL Clone()
		{
			return new DHAIJMPAJDL(this);
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x0007147C File Offset: 0x0006F67C
		// (set) Token: 0x060028BE RID: 10430 RVA: 0x00071484 File Offset: 0x0006F684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x060028BF RID: 10431 RVA: 0x0007148D File Offset: 0x0006F68D
		// (set) Token: 0x060028C0 RID: 10432 RVA: 0x00071495 File Offset: 0x0006F695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CellId
		{
			get
			{
				return this.cellId_;
			}
			set
			{
				this.cellId_ = value;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x060028C1 RID: 10433 RVA: 0x0007149E File Offset: 0x0006F69E
		// (set) Token: 0x060028C2 RID: 10434 RVA: 0x000714A6 File Offset: 0x0006F6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BFEKIKBIMCG
		{
			get
			{
				return this.bFEKIKBIMCG_;
			}
			set
			{
				this.bFEKIKBIMCG_ = value;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x060028C3 RID: 10435 RVA: 0x000714AF File Offset: 0x0006F6AF
		// (set) Token: 0x060028C4 RID: 10436 RVA: 0x000714B7 File Offset: 0x0006F6B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ABNJHBAGOCG PMPFMFNKNGJ
		{
			get
			{
				return this.pMPFMFNKNGJ_;
			}
			set
			{
				this.pMPFMFNKNGJ_ = value;
			}
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x000714C0 File Offset: 0x0006F6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DHAIJMPAJDL);
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000714D0 File Offset: 0x0006F6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DHAIJMPAJDL other)
		{
			return other != null && (other == this || (this.MapId == other.MapId && this.CellId == other.CellId && this.BFEKIKBIMCG == other.BFEKIKBIMCG && this.PMPFMFNKNGJ == other.PMPFMFNKNGJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x0007153C File Offset: 0x0006F73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MapId != 0U)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this.CellId != 0U)
			{
				num ^= this.CellId.GetHashCode();
			}
			if (this.BFEKIKBIMCG)
			{
				num ^= this.BFEKIKBIMCG.GetHashCode();
			}
			if (this.PMPFMFNKNGJ != ABNJHBAGOCG.MonopolyCellStateIdle)
			{
				num ^= this.PMPFMFNKNGJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x000715CC File Offset: 0x0006F7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x000715D4 File Offset: 0x0006F7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x000715E0 File Offset: 0x0006F7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PMPFMFNKNGJ != ABNJHBAGOCG.MonopolyCellStateIdle)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.PMPFMFNKNGJ);
			}
			if (this.BFEKIKBIMCG)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.BFEKIKBIMCG);
			}
			if (this.MapId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MapId);
			}
			if (this.CellId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.CellId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x00071674 File Offset: 0x0006F874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapId);
			}
			if (this.CellId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CellId);
			}
			if (this.BFEKIKBIMCG)
			{
				num += 2;
			}
			if (this.PMPFMFNKNGJ != ABNJHBAGOCG.MonopolyCellStateIdle)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PMPFMFNKNGJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x000716F0 File Offset: 0x0006F8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DHAIJMPAJDL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MapId != 0U)
			{
				this.MapId = other.MapId;
			}
			if (other.CellId != 0U)
			{
				this.CellId = other.CellId;
			}
			if (other.BFEKIKBIMCG)
			{
				this.BFEKIKBIMCG = other.BFEKIKBIMCG;
			}
			if (other.PMPFMFNKNGJ != ABNJHBAGOCG.MonopolyCellStateIdle)
			{
				this.PMPFMFNKNGJ = other.PMPFMFNKNGJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x00071768 File Offset: 0x0006F968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x00071774 File Offset: 0x0006F974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 24U)
					{
						this.PMPFMFNKNGJ = (ABNJHBAGOCG)input.ReadEnum();
						continue;
					}
					if (num == 40U)
					{
						this.BFEKIKBIMCG = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.MapId = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.CellId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400106B RID: 4203
		private static readonly MessageParser<DHAIJMPAJDL> _parser = new MessageParser<DHAIJMPAJDL>(() => new DHAIJMPAJDL());

		// Token: 0x0400106C RID: 4204
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400106D RID: 4205
		public const int MapIdFieldNumber = 7;

		// Token: 0x0400106E RID: 4206
		private uint mapId_;

		// Token: 0x0400106F RID: 4207
		public const int CellIdFieldNumber = 9;

		// Token: 0x04001070 RID: 4208
		private uint cellId_;

		// Token: 0x04001071 RID: 4209
		public const int BFEKIKBIMCGFieldNumber = 5;

		// Token: 0x04001072 RID: 4210
		private bool bFEKIKBIMCG_;

		// Token: 0x04001073 RID: 4211
		public const int PMPFMFNKNGJFieldNumber = 3;

		// Token: 0x04001074 RID: 4212
		private ABNJHBAGOCG pMPFMFNKNGJ_;
	}
}
