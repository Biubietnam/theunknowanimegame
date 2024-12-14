using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C61 RID: 3169
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OLFEIIBMPGL : IMessage<OLFEIIBMPGL>, IMessage, IEquatable<OLFEIIBMPGL>, IDeepCloneable<OLFEIIBMPGL>, IBufferMessage
	{
		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x06008CC4 RID: 36036 RVA: 0x00174210 File Offset: 0x00172410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OLFEIIBMPGL> Parser
		{
			get
			{
				return OLFEIIBMPGL._parser;
			}
		}

		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x06008CC5 RID: 36037 RVA: 0x00174217 File Offset: 0x00172417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OLFEIIBMPGLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x06008CC6 RID: 36038 RVA: 0x00174229 File Offset: 0x00172429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OLFEIIBMPGL.Descriptor;
			}
		}

		// Token: 0x06008CC7 RID: 36039 RVA: 0x00174230 File Offset: 0x00172430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OLFEIIBMPGL()
		{
		}

		// Token: 0x06008CC8 RID: 36040 RVA: 0x00174238 File Offset: 0x00172438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OLFEIIBMPGL(OLFEIIBMPGL other) : this()
		{
			this.areaId_ = other.areaId_;
			this.lCHACGONGJK_ = other.lCHACGONGJK_;
			this.gKCJFIEDJDB_ = other.gKCJFIEDJDB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CC9 RID: 36041 RVA: 0x00174275 File Offset: 0x00172475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OLFEIIBMPGL Clone()
		{
			return new OLFEIIBMPGL(this);
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x06008CCA RID: 36042 RVA: 0x0017427D File Offset: 0x0017247D
		// (set) Token: 0x06008CCB RID: 36043 RVA: 0x00174285 File Offset: 0x00172485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x06008CCC RID: 36044 RVA: 0x0017428E File Offset: 0x0017248E
		// (set) Token: 0x06008CCD RID: 36045 RVA: 0x00174296 File Offset: 0x00172496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LCHACGONGJK
		{
			get
			{
				return this.lCHACGONGJK_;
			}
			set
			{
				this.lCHACGONGJK_ = value;
			}
		}

		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x06008CCE RID: 36046 RVA: 0x0017429F File Offset: 0x0017249F
		// (set) Token: 0x06008CCF RID: 36047 RVA: 0x001742A7 File Offset: 0x001724A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GKCJFIEDJDB
		{
			get
			{
				return this.gKCJFIEDJDB_;
			}
			set
			{
				this.gKCJFIEDJDB_ = value;
			}
		}

		// Token: 0x06008CD0 RID: 36048 RVA: 0x001742B0 File Offset: 0x001724B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OLFEIIBMPGL);
		}

		// Token: 0x06008CD1 RID: 36049 RVA: 0x001742C0 File Offset: 0x001724C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OLFEIIBMPGL other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.LCHACGONGJK == other.LCHACGONGJK && this.GKCJFIEDJDB == other.GKCJFIEDJDB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008CD2 RID: 36050 RVA: 0x0017431C File Offset: 0x0017251C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.LCHACGONGJK != 0U)
			{
				num ^= this.LCHACGONGJK.GetHashCode();
			}
			if (this.GKCJFIEDJDB != 0U)
			{
				num ^= this.GKCJFIEDJDB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008CD3 RID: 36051 RVA: 0x0017438D File Offset: 0x0017258D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008CD4 RID: 36052 RVA: 0x00174395 File Offset: 0x00172595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CD5 RID: 36053 RVA: 0x001743A0 File Offset: 0x001725A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.AreaId);
			}
			if (this.LCHACGONGJK != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.LCHACGONGJK);
			}
			if (this.GKCJFIEDJDB != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.GKCJFIEDJDB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CD6 RID: 36054 RVA: 0x00174418 File Offset: 0x00172618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this.LCHACGONGJK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LCHACGONGJK);
			}
			if (this.GKCJFIEDJDB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GKCJFIEDJDB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008CD7 RID: 36055 RVA: 0x00174488 File Offset: 0x00172688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OLFEIIBMPGL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			if (other.LCHACGONGJK != 0U)
			{
				this.LCHACGONGJK = other.LCHACGONGJK;
			}
			if (other.GKCJFIEDJDB != 0U)
			{
				this.GKCJFIEDJDB = other.GKCJFIEDJDB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008CD8 RID: 36056 RVA: 0x001744EC File Offset: 0x001726EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CD9 RID: 36057 RVA: 0x001744F8 File Offset: 0x001726F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 72U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GKCJFIEDJDB = input.ReadUInt32();
						}
					}
					else
					{
						this.LCHACGONGJK = input.ReadUInt32();
					}
				}
				else
				{
					this.AreaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003612 RID: 13842
		private static readonly MessageParser<OLFEIIBMPGL> _parser = new MessageParser<OLFEIIBMPGL>(() => new OLFEIIBMPGL());

		// Token: 0x04003613 RID: 13843
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003614 RID: 13844
		public const int AreaIdFieldNumber = 7;

		// Token: 0x04003615 RID: 13845
		private uint areaId_;

		// Token: 0x04003616 RID: 13846
		public const int LCHACGONGJKFieldNumber = 9;

		// Token: 0x04003617 RID: 13847
		private uint lCHACGONGJK_;

		// Token: 0x04003618 RID: 13848
		public const int GKCJFIEDJDBFieldNumber = 10;

		// Token: 0x04003619 RID: 13849
		private uint gKCJFIEDJDB_;
	}
}
