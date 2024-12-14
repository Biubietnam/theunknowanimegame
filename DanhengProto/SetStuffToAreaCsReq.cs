using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001137 RID: 4407
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetStuffToAreaCsReq : IMessage<SetStuffToAreaCsReq>, IMessage, IEquatable<SetStuffToAreaCsReq>, IDeepCloneable<SetStuffToAreaCsReq>, IBufferMessage
	{
		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x0600C485 RID: 50309 RVA: 0x0020F759 File Offset: 0x0020D959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetStuffToAreaCsReq> Parser
		{
			get
			{
				return SetStuffToAreaCsReq._parser;
			}
		}

		// Token: 0x1700376B RID: 14187
		// (get) Token: 0x0600C486 RID: 50310 RVA: 0x0020F760 File Offset: 0x0020D960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetStuffToAreaCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700376C RID: 14188
		// (get) Token: 0x0600C487 RID: 50311 RVA: 0x0020F772 File Offset: 0x0020D972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetStuffToAreaCsReq.Descriptor;
			}
		}

		// Token: 0x0600C488 RID: 50312 RVA: 0x0020F779 File Offset: 0x0020D979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetStuffToAreaCsReq()
		{
		}

		// Token: 0x0600C489 RID: 50313 RVA: 0x0020F781 File Offset: 0x0020D981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetStuffToAreaCsReq(SetStuffToAreaCsReq other) : this()
		{
			this.nOJOJKCJEOI_ = other.nOJOJKCJEOI_;
			this.pOEDFMELAKE_ = other.pOEDFMELAKE_;
			this.pos_ = other.pos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C48A RID: 50314 RVA: 0x0020F7BE File Offset: 0x0020D9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetStuffToAreaCsReq Clone()
		{
			return new SetStuffToAreaCsReq(this);
		}

		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x0600C48B RID: 50315 RVA: 0x0020F7C6 File Offset: 0x0020D9C6
		// (set) Token: 0x0600C48C RID: 50316 RVA: 0x0020F7CE File Offset: 0x0020D9CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NOJOJKCJEOI
		{
			get
			{
				return this.nOJOJKCJEOI_;
			}
			set
			{
				this.nOJOJKCJEOI_ = value;
			}
		}

		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x0600C48D RID: 50317 RVA: 0x0020F7D7 File Offset: 0x0020D9D7
		// (set) Token: 0x0600C48E RID: 50318 RVA: 0x0020F7DF File Offset: 0x0020D9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint POEDFMELAKE
		{
			get
			{
				return this.pOEDFMELAKE_;
			}
			set
			{
				this.pOEDFMELAKE_ = value;
			}
		}

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x0600C48F RID: 50319 RVA: 0x0020F7E8 File Offset: 0x0020D9E8
		// (set) Token: 0x0600C490 RID: 50320 RVA: 0x0020F7F0 File Offset: 0x0020D9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DAEALPIOKMG Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x0600C491 RID: 50321 RVA: 0x0020F7F9 File Offset: 0x0020D9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetStuffToAreaCsReq);
		}

		// Token: 0x0600C492 RID: 50322 RVA: 0x0020F808 File Offset: 0x0020DA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetStuffToAreaCsReq other)
		{
			return other != null && (other == this || (this.NOJOJKCJEOI == other.NOJOJKCJEOI && this.POEDFMELAKE == other.POEDFMELAKE && this.Pos == other.Pos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C493 RID: 50323 RVA: 0x0020F864 File Offset: 0x0020DA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NOJOJKCJEOI != 0U)
			{
				num ^= this.NOJOJKCJEOI.GetHashCode();
			}
			if (this.POEDFMELAKE != 0U)
			{
				num ^= this.POEDFMELAKE.GetHashCode();
			}
			if (this.Pos != DAEALPIOKMG.WorkPosNone)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C494 RID: 50324 RVA: 0x0020F8DB File Offset: 0x0020DADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C495 RID: 50325 RVA: 0x0020F8E3 File Offset: 0x0020DAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C496 RID: 50326 RVA: 0x0020F8EC File Offset: 0x0020DAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.POEDFMELAKE != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.POEDFMELAKE);
			}
			if (this.NOJOJKCJEOI != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.NOJOJKCJEOI);
			}
			if (this.Pos != DAEALPIOKMG.WorkPosNone)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C497 RID: 50327 RVA: 0x0020F964 File Offset: 0x0020DB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NOJOJKCJEOI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NOJOJKCJEOI);
			}
			if (this.POEDFMELAKE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.POEDFMELAKE);
			}
			if (this.Pos != DAEALPIOKMG.WorkPosNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C498 RID: 50328 RVA: 0x0020F9D4 File Offset: 0x0020DBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetStuffToAreaCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NOJOJKCJEOI != 0U)
			{
				this.NOJOJKCJEOI = other.NOJOJKCJEOI;
			}
			if (other.POEDFMELAKE != 0U)
			{
				this.POEDFMELAKE = other.POEDFMELAKE;
			}
			if (other.Pos != DAEALPIOKMG.WorkPosNone)
			{
				this.Pos = other.Pos;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C499 RID: 50329 RVA: 0x0020FA38 File Offset: 0x0020DC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C49A RID: 50330 RVA: 0x0020FA44 File Offset: 0x0020DC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 80U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Pos = (DAEALPIOKMG)input.ReadEnum();
						}
					}
					else
					{
						this.NOJOJKCJEOI = input.ReadUInt32();
					}
				}
				else
				{
					this.POEDFMELAKE = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004F64 RID: 20324
		private static readonly MessageParser<SetStuffToAreaCsReq> _parser = new MessageParser<SetStuffToAreaCsReq>(() => new SetStuffToAreaCsReq());

		// Token: 0x04004F65 RID: 20325
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F66 RID: 20326
		public const int NOJOJKCJEOIFieldNumber = 10;

		// Token: 0x04004F67 RID: 20327
		private uint nOJOJKCJEOI_;

		// Token: 0x04004F68 RID: 20328
		public const int POEDFMELAKEFieldNumber = 9;

		// Token: 0x04004F69 RID: 20329
		private uint pOEDFMELAKE_;

		// Token: 0x04004F6A RID: 20330
		public const int PosFieldNumber = 15;

		// Token: 0x04004F6B RID: 20331
		private DAEALPIOKMG pos_;
	}
}
