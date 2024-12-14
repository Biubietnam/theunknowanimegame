using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003B7 RID: 951
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DKPPCLLGIMC : IMessage<DKPPCLLGIMC>, IMessage, IEquatable<DKPPCLLGIMC>, IDeepCloneable<DKPPCLLGIMC>, IBufferMessage
	{
		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06002A5B RID: 10843 RVA: 0x00075E85 File Offset: 0x00074085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DKPPCLLGIMC> Parser
		{
			get
			{
				return DKPPCLLGIMC._parser;
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x00075E8C File Offset: 0x0007408C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DKPPCLLGIMCReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06002A5D RID: 10845 RVA: 0x00075E9E File Offset: 0x0007409E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DKPPCLLGIMC.Descriptor;
			}
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x00075EA5 File Offset: 0x000740A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DKPPCLLGIMC()
		{
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x00075EB0 File Offset: 0x000740B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DKPPCLLGIMC(DKPPCLLGIMC other) : this()
		{
			this.gachaRandom_ = other.gachaRandom_;
			this.pEGAOAAFIJF_ = other.pEGAOAAFIJF_;
			this.mALKHNFHFAE_ = ((other.mALKHNFHFAE_ != null) ? other.mALKHNFHFAE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x00075F08 File Offset: 0x00074108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DKPPCLLGIMC Clone()
		{
			return new DKPPCLLGIMC(this);
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06002A61 RID: 10849 RVA: 0x00075F10 File Offset: 0x00074110
		// (set) Token: 0x06002A62 RID: 10850 RVA: 0x00075F18 File Offset: 0x00074118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaRandom
		{
			get
			{
				return this.gachaRandom_;
			}
			set
			{
				this.gachaRandom_ = value;
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06002A63 RID: 10851 RVA: 0x00075F21 File Offset: 0x00074121
		// (set) Token: 0x06002A64 RID: 10852 RVA: 0x00075F29 File Offset: 0x00074129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PEGAOAAFIJF
		{
			get
			{
				return this.pEGAOAAFIJF_;
			}
			set
			{
				this.pEGAOAAFIJF_ = value;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06002A65 RID: 10853 RVA: 0x00075F32 File Offset: 0x00074132
		// (set) Token: 0x06002A66 RID: 10854 RVA: 0x00075F3A File Offset: 0x0007413A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DPCAMGELHBP MALKHNFHFAE
		{
			get
			{
				return this.mALKHNFHFAE_;
			}
			set
			{
				this.mALKHNFHFAE_ = value;
			}
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x00075F43 File Offset: 0x00074143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DKPPCLLGIMC);
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x00075F54 File Offset: 0x00074154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DKPPCLLGIMC other)
		{
			return other != null && (other == this || (this.GachaRandom == other.GachaRandom && this.PEGAOAAFIJF == other.PEGAOAAFIJF && object.Equals(this.MALKHNFHFAE, other.MALKHNFHFAE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x00075FB4 File Offset: 0x000741B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaRandom != 0U)
			{
				num ^= this.GachaRandom.GetHashCode();
			}
			if (this.PEGAOAAFIJF != 0U)
			{
				num ^= this.PEGAOAAFIJF.GetHashCode();
			}
			if (this.mALKHNFHFAE_ != null)
			{
				num ^= this.MALKHNFHFAE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x00076022 File Offset: 0x00074222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x0007602A File Offset: 0x0007422A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x00076034 File Offset: 0x00074234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaRandom != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GachaRandom);
			}
			if (this.mALKHNFHFAE_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.MALKHNFHFAE);
			}
			if (this.PEGAOAAFIJF != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.PEGAOAAFIJF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x000760A8 File Offset: 0x000742A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaRandom != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaRandom);
			}
			if (this.PEGAOAAFIJF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PEGAOAAFIJF);
			}
			if (this.mALKHNFHFAE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MALKHNFHFAE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x00076118 File Offset: 0x00074318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DKPPCLLGIMC other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaRandom != 0U)
			{
				this.GachaRandom = other.GachaRandom;
			}
			if (other.PEGAOAAFIJF != 0U)
			{
				this.PEGAOAAFIJF = other.PEGAOAAFIJF;
			}
			if (other.mALKHNFHFAE_ != null)
			{
				if (this.mALKHNFHFAE_ == null)
				{
					this.MALKHNFHFAE = new DPCAMGELHBP();
				}
				this.MALKHNFHFAE.MergeFrom(other.MALKHNFHFAE);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x00076194 File Offset: 0x00074394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x000761A0 File Offset: 0x000743A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 82U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PEGAOAAFIJF = input.ReadUInt32();
						}
					}
					else
					{
						if (this.mALKHNFHFAE_ == null)
						{
							this.MALKHNFHFAE = new DPCAMGELHBP();
						}
						input.ReadMessage(this.MALKHNFHFAE);
					}
				}
				else
				{
					this.GachaRandom = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001121 RID: 4385
		private static readonly MessageParser<DKPPCLLGIMC> _parser = new MessageParser<DKPPCLLGIMC>(() => new DKPPCLLGIMC());

		// Token: 0x04001122 RID: 4386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001123 RID: 4387
		public const int GachaRandomFieldNumber = 1;

		// Token: 0x04001124 RID: 4388
		private uint gachaRandom_;

		// Token: 0x04001125 RID: 4389
		public const int PEGAOAAFIJFFieldNumber = 15;

		// Token: 0x04001126 RID: 4390
		private uint pEGAOAAFIJF_;

		// Token: 0x04001127 RID: 4391
		public const int MALKHNFHFAEFieldNumber = 10;

		// Token: 0x04001128 RID: 4392
		private DPCAMGELHBP mALKHNFHFAE_;
	}
}
