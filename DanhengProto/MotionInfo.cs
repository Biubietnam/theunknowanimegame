using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B97 RID: 2967
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MotionInfo : IMessage<MotionInfo>, IMessage, IEquatable<MotionInfo>, IDeepCloneable<MotionInfo>, IBufferMessage
	{
		// Token: 0x170024DE RID: 9438
		// (get) Token: 0x0600837E RID: 33662 RVA: 0x0015B2C0 File Offset: 0x001594C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotionInfo> Parser
		{
			get
			{
				return MotionInfo._parser;
			}
		}

		// Token: 0x170024DF RID: 9439
		// (get) Token: 0x0600837F RID: 33663 RVA: 0x0015B2C7 File Offset: 0x001594C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MotionInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170024E0 RID: 9440
		// (get) Token: 0x06008380 RID: 33664 RVA: 0x0015B2D9 File Offset: 0x001594D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotionInfo.Descriptor;
			}
		}

		// Token: 0x06008381 RID: 33665 RVA: 0x0015B2E0 File Offset: 0x001594E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo()
		{
		}

		// Token: 0x06008382 RID: 33666 RVA: 0x0015B2E8 File Offset: 0x001594E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo(MotionInfo other) : this()
		{
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008383 RID: 33667 RVA: 0x0015B344 File Offset: 0x00159544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo Clone()
		{
			return new MotionInfo(this);
		}

		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x06008384 RID: 33668 RVA: 0x0015B34C File Offset: 0x0015954C
		// (set) Token: 0x06008385 RID: 33669 RVA: 0x0015B354 File Offset: 0x00159554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Rot
		{
			get
			{
				return this.rot_;
			}
			set
			{
				this.rot_ = value;
			}
		}

		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x06008386 RID: 33670 RVA: 0x0015B35D File Offset: 0x0015955D
		// (set) Token: 0x06008387 RID: 33671 RVA: 0x0015B365 File Offset: 0x00159565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
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

		// Token: 0x06008388 RID: 33672 RVA: 0x0015B36E File Offset: 0x0015956E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotionInfo);
		}

		// Token: 0x06008389 RID: 33673 RVA: 0x0015B37C File Offset: 0x0015957C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotionInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Rot, other.Rot) && object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600838A RID: 33674 RVA: 0x0015B3D0 File Offset: 0x001595D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600838B RID: 33675 RVA: 0x0015B422 File Offset: 0x00159622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600838C RID: 33676 RVA: 0x0015B42A File Offset: 0x0015962A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600838D RID: 33677 RVA: 0x0015B434 File Offset: 0x00159634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Pos);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Rot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600838E RID: 33678 RVA: 0x0015B490 File Offset: 0x00159690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600838F RID: 33679 RVA: 0x0015B4E8 File Offset: 0x001596E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rot_ != null)
			{
				if (this.rot_ == null)
				{
					this.Rot = new Vector();
				}
				this.Rot.MergeFrom(other.Rot);
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008390 RID: 33680 RVA: 0x0015B568 File Offset: 0x00159768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008391 RID: 33681 RVA: 0x0015B574 File Offset: 0x00159774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rot_ == null)
						{
							this.Rot = new Vector();
						}
						input.ReadMessage(this.Rot);
					}
				}
				else
				{
					if (this.pos_ == null)
					{
						this.Pos = new Vector();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x0400324C RID: 12876
		private static readonly MessageParser<MotionInfo> _parser = new MessageParser<MotionInfo>(() => new MotionInfo());

		// Token: 0x0400324D RID: 12877
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400324E RID: 12878
		public const int RotFieldNumber = 3;

		// Token: 0x0400324F RID: 12879
		private Vector rot_;

		// Token: 0x04003250 RID: 12880
		public const int PosFieldNumber = 2;

		// Token: 0x04003251 RID: 12881
		private Vector pos_;
	}
}
