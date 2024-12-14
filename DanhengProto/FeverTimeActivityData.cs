using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000519 RID: 1305
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FeverTimeActivityData : IMessage<FeverTimeActivityData>, IMessage, IEquatable<FeverTimeActivityData>, IDeepCloneable<FeverTimeActivityData>, IBufferMessage
	{
		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06003A68 RID: 14952 RVA: 0x000A0A9F File Offset: 0x0009EC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FeverTimeActivityData> Parser
		{
			get
			{
				return FeverTimeActivityData._parser;
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06003A69 RID: 14953 RVA: 0x000A0AA6 File Offset: 0x0009ECA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FeverTimeActivityDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06003A6A RID: 14954 RVA: 0x000A0AB8 File Offset: 0x0009ECB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeverTimeActivityData.Descriptor;
			}
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x000A0ABF File Offset: 0x0009ECBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeverTimeActivityData()
		{
		}

		// Token: 0x06003A6C RID: 14956 RVA: 0x000A0AC7 File Offset: 0x0009ECC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeverTimeActivityData(FeverTimeActivityData other) : this()
		{
			this.gHIKGGJMIKF_ = other.gHIKGGJMIKF_;
			this.ePJPMBMOKAJ_ = other.ePJPMBMOKAJ_;
			this.hLJELCNLJKI_ = other.hLJELCNLJKI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x000A0B04 File Offset: 0x0009ED04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeverTimeActivityData Clone()
		{
			return new FeverTimeActivityData(this);
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06003A6E RID: 14958 RVA: 0x000A0B0C File Offset: 0x0009ED0C
		// (set) Token: 0x06003A6F RID: 14959 RVA: 0x000A0B14 File Offset: 0x0009ED14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GHIKGGJMIKF
		{
			get
			{
				return this.gHIKGGJMIKF_;
			}
			set
			{
				this.gHIKGGJMIKF_ = value;
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x000A0B1D File Offset: 0x0009ED1D
		// (set) Token: 0x06003A71 RID: 14961 RVA: 0x000A0B25 File Offset: 0x0009ED25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EPJPMBMOKAJ
		{
			get
			{
				return this.ePJPMBMOKAJ_;
			}
			set
			{
				this.ePJPMBMOKAJ_ = value;
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x000A0B2E File Offset: 0x0009ED2E
		// (set) Token: 0x06003A73 RID: 14963 RVA: 0x000A0B36 File Offset: 0x0009ED36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeverTimeBattleRank HLJELCNLJKI
		{
			get
			{
				return this.hLJELCNLJKI_;
			}
			set
			{
				this.hLJELCNLJKI_ = value;
			}
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x000A0B3F File Offset: 0x0009ED3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeverTimeActivityData);
		}

		// Token: 0x06003A75 RID: 14965 RVA: 0x000A0B50 File Offset: 0x0009ED50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeverTimeActivityData other)
		{
			return other != null && (other == this || (this.GHIKGGJMIKF == other.GHIKGGJMIKF && this.EPJPMBMOKAJ == other.EPJPMBMOKAJ && this.HLJELCNLJKI == other.HLJELCNLJKI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x000A0BAC File Offset: 0x0009EDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GHIKGGJMIKF != 0U)
			{
				num ^= this.GHIKGGJMIKF.GetHashCode();
			}
			if (this.EPJPMBMOKAJ != 0U)
			{
				num ^= this.EPJPMBMOKAJ.GetHashCode();
			}
			if (this.HLJELCNLJKI != FeverTimeBattleRank.C)
			{
				num ^= this.HLJELCNLJKI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x000A0C23 File Offset: 0x0009EE23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x000A0C2B File Offset: 0x0009EE2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A79 RID: 14969 RVA: 0x000A0C34 File Offset: 0x0009EE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EPJPMBMOKAJ != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.EPJPMBMOKAJ);
			}
			if (this.GHIKGGJMIKF != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.GHIKGGJMIKF);
			}
			if (this.HLJELCNLJKI != FeverTimeBattleRank.C)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.HLJELCNLJKI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x000A0CAC File Offset: 0x0009EEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GHIKGGJMIKF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GHIKGGJMIKF);
			}
			if (this.EPJPMBMOKAJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EPJPMBMOKAJ);
			}
			if (this.HLJELCNLJKI != FeverTimeBattleRank.C)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.HLJELCNLJKI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x000A0D1C File Offset: 0x0009EF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FeverTimeActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GHIKGGJMIKF != 0U)
			{
				this.GHIKGGJMIKF = other.GHIKGGJMIKF;
			}
			if (other.EPJPMBMOKAJ != 0U)
			{
				this.EPJPMBMOKAJ = other.EPJPMBMOKAJ;
			}
			if (other.HLJELCNLJKI != FeverTimeBattleRank.C)
			{
				this.HLJELCNLJKI = other.HLJELCNLJKI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x000A0D80 File Offset: 0x0009EF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x000A0D8C File Offset: 0x0009EF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 72U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HLJELCNLJKI = (FeverTimeBattleRank)input.ReadEnum();
						}
					}
					else
					{
						this.GHIKGGJMIKF = input.ReadUInt32();
					}
				}
				else
				{
					this.EPJPMBMOKAJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001778 RID: 6008
		private static readonly MessageParser<FeverTimeActivityData> _parser = new MessageParser<FeverTimeActivityData>(() => new FeverTimeActivityData());

		// Token: 0x04001779 RID: 6009
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400177A RID: 6010
		public const int GHIKGGJMIKFFieldNumber = 9;

		// Token: 0x0400177B RID: 6011
		private uint gHIKGGJMIKF_;

		// Token: 0x0400177C RID: 6012
		public const int EPJPMBMOKAJFieldNumber = 6;

		// Token: 0x0400177D RID: 6013
		private uint ePJPMBMOKAJ_;

		// Token: 0x0400177E RID: 6014
		public const int HLJELCNLJKIFieldNumber = 14;

		// Token: 0x0400177F RID: 6015
		private FeverTimeBattleRank hLJELCNLJKI_;
	}
}
