using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DC9 RID: 3529
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ResetMapRotationRegionCsReq : IMessage<ResetMapRotationRegionCsReq>, IMessage, IEquatable<ResetMapRotationRegionCsReq>, IDeepCloneable<ResetMapRotationRegionCsReq>, IBufferMessage
	{
		// Token: 0x17002C8D RID: 11405
		// (get) Token: 0x06009DC9 RID: 40393 RVA: 0x001A454F File Offset: 0x001A274F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ResetMapRotationRegionCsReq> Parser
		{
			get
			{
				return ResetMapRotationRegionCsReq._parser;
			}
		}

		// Token: 0x17002C8E RID: 11406
		// (get) Token: 0x06009DCA RID: 40394 RVA: 0x001A4556 File Offset: 0x001A2756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ResetMapRotationRegionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C8F RID: 11407
		// (get) Token: 0x06009DCB RID: 40395 RVA: 0x001A4568 File Offset: 0x001A2768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetMapRotationRegionCsReq.Descriptor;
			}
		}

		// Token: 0x06009DCC RID: 40396 RVA: 0x001A456F File Offset: 0x001A276F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetMapRotationRegionCsReq()
		{
		}

		// Token: 0x06009DCD RID: 40397 RVA: 0x001A4578 File Offset: 0x001A2778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetMapRotationRegionCsReq(ResetMapRotationRegionCsReq other) : this()
		{
			this.roomMap_ = ((other.roomMap_ != null) ? other.roomMap_.Clone() : null);
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DCE RID: 40398 RVA: 0x001A45D4 File Offset: 0x001A27D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetMapRotationRegionCsReq Clone()
		{
			return new ResetMapRotationRegionCsReq(this);
		}

		// Token: 0x17002C90 RID: 11408
		// (get) Token: 0x06009DCF RID: 40399 RVA: 0x001A45DC File Offset: 0x001A27DC
		// (set) Token: 0x06009DD0 RID: 40400 RVA: 0x001A45E4 File Offset: 0x001A27E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HMBLIADNKEO RoomMap
		{
			get
			{
				return this.roomMap_;
			}
			set
			{
				this.roomMap_ = value;
			}
		}

		// Token: 0x17002C91 RID: 11409
		// (get) Token: 0x06009DD1 RID: 40401 RVA: 0x001A45ED File Offset: 0x001A27ED
		// (set) Token: 0x06009DD2 RID: 40402 RVA: 0x001A45F5 File Offset: 0x001A27F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo Motion
		{
			get
			{
				return this.motion_;
			}
			set
			{
				this.motion_ = value;
			}
		}

		// Token: 0x06009DD3 RID: 40403 RVA: 0x001A45FE File Offset: 0x001A27FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetMapRotationRegionCsReq);
		}

		// Token: 0x06009DD4 RID: 40404 RVA: 0x001A460C File Offset: 0x001A280C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResetMapRotationRegionCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.RoomMap, other.RoomMap) && object.Equals(this.Motion, other.Motion) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009DD5 RID: 40405 RVA: 0x001A4660 File Offset: 0x001A2860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roomMap_ != null)
			{
				num ^= this.RoomMap.GetHashCode();
			}
			if (this.motion_ != null)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009DD6 RID: 40406 RVA: 0x001A46B2 File Offset: 0x001A28B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009DD7 RID: 40407 RVA: 0x001A46BA File Offset: 0x001A28BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DD8 RID: 40408 RVA: 0x001A46C4 File Offset: 0x001A28C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motion_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Motion);
			}
			if (this.roomMap_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RoomMap);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009DD9 RID: 40409 RVA: 0x001A4720 File Offset: 0x001A2920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roomMap_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoomMap);
			}
			if (this.motion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009DDA RID: 40410 RVA: 0x001A4778 File Offset: 0x001A2978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResetMapRotationRegionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.roomMap_ != null)
			{
				if (this.roomMap_ == null)
				{
					this.RoomMap = new HMBLIADNKEO();
				}
				this.RoomMap.MergeFrom(other.RoomMap);
			}
			if (other.motion_ != null)
			{
				if (this.motion_ == null)
				{
					this.Motion = new MotionInfo();
				}
				this.Motion.MergeFrom(other.Motion);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009DDB RID: 40411 RVA: 0x001A47F8 File Offset: 0x001A29F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DDC RID: 40412 RVA: 0x001A4804 File Offset: 0x001A2A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.roomMap_ == null)
						{
							this.RoomMap = new HMBLIADNKEO();
						}
						input.ReadMessage(this.RoomMap);
					}
				}
				else
				{
					if (this.motion_ == null)
					{
						this.Motion = new MotionInfo();
					}
					input.ReadMessage(this.Motion);
				}
			}
		}

		// Token: 0x04003D59 RID: 15705
		private static readonly MessageParser<ResetMapRotationRegionCsReq> _parser = new MessageParser<ResetMapRotationRegionCsReq>(() => new ResetMapRotationRegionCsReq());

		// Token: 0x04003D5A RID: 15706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D5B RID: 15707
		public const int RoomMapFieldNumber = 9;

		// Token: 0x04003D5C RID: 15708
		private HMBLIADNKEO roomMap_;

		// Token: 0x04003D5D RID: 15709
		public const int MotionFieldNumber = 7;

		// Token: 0x04003D5E RID: 15710
		private MotionInfo motion_;
	}
}
