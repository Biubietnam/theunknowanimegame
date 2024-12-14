using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A7B RID: 2683
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MakeMissionDrinkCsReq : IMessage<MakeMissionDrinkCsReq>, IMessage, IEquatable<MakeMissionDrinkCsReq>, IDeepCloneable<MakeMissionDrinkCsReq>, IBufferMessage
	{
		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x060076E7 RID: 30439 RVA: 0x0013B803 File Offset: 0x00139A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MakeMissionDrinkCsReq> Parser
		{
			get
			{
				return MakeMissionDrinkCsReq._parser;
			}
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x060076E8 RID: 30440 RVA: 0x0013B80A File Offset: 0x00139A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MakeMissionDrinkCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x060076E9 RID: 30441 RVA: 0x0013B81C File Offset: 0x00139A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MakeMissionDrinkCsReq.Descriptor;
			}
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x0013B823 File Offset: 0x00139A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MakeMissionDrinkCsReq()
		{
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x0013B82C File Offset: 0x00139A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MakeMissionDrinkCsReq(MakeMissionDrinkCsReq other) : this()
		{
			this.oAPJFLKLHEH_ = other.oAPJFLKLHEH_;
			this.oEEHEOKKNGD_ = ((other.oEEHEOKKNGD_ != null) ? other.oEEHEOKKNGD_.Clone() : null);
			this.isSaveData_ = other.isSaveData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x0013B884 File Offset: 0x00139A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MakeMissionDrinkCsReq Clone()
		{
			return new MakeMissionDrinkCsReq(this);
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x060076ED RID: 30445 RVA: 0x0013B88C File Offset: 0x00139A8C
		// (set) Token: 0x060076EE RID: 30446 RVA: 0x0013B894 File Offset: 0x00139A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OAPJFLKLHEH
		{
			get
			{
				return this.oAPJFLKLHEH_;
			}
			set
			{
				this.oAPJFLKLHEH_ = value;
			}
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x060076EF RID: 30447 RVA: 0x0013B89D File Offset: 0x00139A9D
		// (set) Token: 0x060076F0 RID: 30448 RVA: 0x0013B8A5 File Offset: 0x00139AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LGNIOADJNOJ OEEHEOKKNGD
		{
			get
			{
				return this.oEEHEOKKNGD_;
			}
			set
			{
				this.oEEHEOKKNGD_ = value;
			}
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x060076F1 RID: 30449 RVA: 0x0013B8AE File Offset: 0x00139AAE
		// (set) Token: 0x060076F2 RID: 30450 RVA: 0x0013B8B6 File Offset: 0x00139AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSaveData
		{
			get
			{
				return this.isSaveData_;
			}
			set
			{
				this.isSaveData_ = value;
			}
		}

		// Token: 0x060076F3 RID: 30451 RVA: 0x0013B8BF File Offset: 0x00139ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MakeMissionDrinkCsReq);
		}

		// Token: 0x060076F4 RID: 30452 RVA: 0x0013B8D0 File Offset: 0x00139AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MakeMissionDrinkCsReq other)
		{
			return other != null && (other == this || (this.OAPJFLKLHEH == other.OAPJFLKLHEH && object.Equals(this.OEEHEOKKNGD, other.OEEHEOKKNGD) && this.IsSaveData == other.IsSaveData && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060076F5 RID: 30453 RVA: 0x0013B930 File Offset: 0x00139B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OAPJFLKLHEH != 0U)
			{
				num ^= this.OAPJFLKLHEH.GetHashCode();
			}
			if (this.oEEHEOKKNGD_ != null)
			{
				num ^= this.OEEHEOKKNGD.GetHashCode();
			}
			if (this.IsSaveData)
			{
				num ^= this.IsSaveData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060076F6 RID: 30454 RVA: 0x0013B99E File Offset: 0x00139B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060076F7 RID: 30455 RVA: 0x0013B9A6 File Offset: 0x00139BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076F8 RID: 30456 RVA: 0x0013B9B0 File Offset: 0x00139BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OAPJFLKLHEH != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.OAPJFLKLHEH);
			}
			if (this.oEEHEOKKNGD_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.OEEHEOKKNGD);
			}
			if (this.IsSaveData)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsSaveData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076F9 RID: 30457 RVA: 0x0013BA28 File Offset: 0x00139C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OAPJFLKLHEH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OAPJFLKLHEH);
			}
			if (this.oEEHEOKKNGD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OEEHEOKKNGD);
			}
			if (this.IsSaveData)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060076FA RID: 30458 RVA: 0x0013BA8C File Offset: 0x00139C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MakeMissionDrinkCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OAPJFLKLHEH != 0U)
			{
				this.OAPJFLKLHEH = other.OAPJFLKLHEH;
			}
			if (other.oEEHEOKKNGD_ != null)
			{
				if (this.oEEHEOKKNGD_ == null)
				{
					this.OEEHEOKKNGD = new LGNIOADJNOJ();
				}
				this.OEEHEOKKNGD.MergeFrom(other.OEEHEOKKNGD);
			}
			if (other.IsSaveData)
			{
				this.IsSaveData = other.IsSaveData;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060076FB RID: 30459 RVA: 0x0013BB08 File Offset: 0x00139D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076FC RID: 30460 RVA: 0x0013BB14 File Offset: 0x00139D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 74U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsSaveData = input.ReadBool();
						}
					}
					else
					{
						if (this.oEEHEOKKNGD_ == null)
						{
							this.OEEHEOKKNGD = new LGNIOADJNOJ();
						}
						input.ReadMessage(this.OEEHEOKKNGD);
					}
				}
				else
				{
					this.OAPJFLKLHEH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002DAF RID: 11695
		private static readonly MessageParser<MakeMissionDrinkCsReq> _parser = new MessageParser<MakeMissionDrinkCsReq>(() => new MakeMissionDrinkCsReq());

		// Token: 0x04002DB0 RID: 11696
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DB1 RID: 11697
		public const int OAPJFLKLHEHFieldNumber = 2;

		// Token: 0x04002DB2 RID: 11698
		private uint oAPJFLKLHEH_;

		// Token: 0x04002DB3 RID: 11699
		public const int OEEHEOKKNGDFieldNumber = 9;

		// Token: 0x04002DB4 RID: 11700
		private LGNIOADJNOJ oEEHEOKKNGD_;

		// Token: 0x04002DB5 RID: 11701
		public const int IsSaveDataFieldNumber = 13;

		// Token: 0x04002DB6 RID: 11702
		private bool isSaveData_;
	}
}
