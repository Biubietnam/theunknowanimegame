using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000483 RID: 1155
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EntityBindPropCsReq : IMessage<EntityBindPropCsReq>, IMessage, IEquatable<EntityBindPropCsReq>, IDeepCloneable<EntityBindPropCsReq>, IBufferMessage
	{
		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06003371 RID: 13169 RVA: 0x0008D605 File Offset: 0x0008B805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityBindPropCsReq> Parser
		{
			get
			{
				return EntityBindPropCsReq._parser;
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06003372 RID: 13170 RVA: 0x0008D60C File Offset: 0x0008B80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EntityBindPropCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06003373 RID: 13171 RVA: 0x0008D61E File Offset: 0x0008B81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBindPropCsReq.Descriptor;
			}
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x0008D625 File Offset: 0x0008B825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBindPropCsReq()
		{
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x0008D630 File Offset: 0x0008B830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBindPropCsReq(EntityBindPropCsReq other) : this()
		{
			this.aGJMAAKNJMM_ = other.aGJMAAKNJMM_;
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x0008D67C File Offset: 0x0008B87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBindPropCsReq Clone()
		{
			return new EntityBindPropCsReq(this);
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06003377 RID: 13175 RVA: 0x0008D684 File Offset: 0x0008B884
		// (set) Token: 0x06003378 RID: 13176 RVA: 0x0008D68C File Offset: 0x0008B88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AGJMAAKNJMM
		{
			get
			{
				return this.aGJMAAKNJMM_;
			}
			set
			{
				this.aGJMAAKNJMM_ = value;
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06003379 RID: 13177 RVA: 0x0008D695 File Offset: 0x0008B895
		// (set) Token: 0x0600337A RID: 13178 RVA: 0x0008D69D File Offset: 0x0008B89D
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

		// Token: 0x0600337B RID: 13179 RVA: 0x0008D6A6 File Offset: 0x0008B8A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBindPropCsReq);
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x0008D6B4 File Offset: 0x0008B8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBindPropCsReq other)
		{
			return other != null && (other == this || (this.AGJMAAKNJMM == other.AGJMAAKNJMM && object.Equals(this.Motion, other.Motion) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x0008D704 File Offset: 0x0008B904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AGJMAAKNJMM)
			{
				num ^= this.AGJMAAKNJMM.GetHashCode();
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

		// Token: 0x0600337E RID: 13182 RVA: 0x0008D759 File Offset: 0x0008B959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x0008D761 File Offset: 0x0008B961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x0008D76C File Offset: 0x0008B96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AGJMAAKNJMM)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.AGJMAAKNJMM);
			}
			if (this.motion_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Motion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x0008D7C4 File Offset: 0x0008B9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AGJMAAKNJMM)
			{
				num += 2;
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

		// Token: 0x06003382 RID: 13186 RVA: 0x0008D810 File Offset: 0x0008BA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBindPropCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AGJMAAKNJMM)
			{
				this.AGJMAAKNJMM = other.AGJMAAKNJMM;
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

		// Token: 0x06003383 RID: 13187 RVA: 0x0008D878 File Offset: 0x0008BA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x0008D884 File Offset: 0x0008BA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.AGJMAAKNJMM = input.ReadBool();
				}
			}
		}

		// Token: 0x04001471 RID: 5233
		private static readonly MessageParser<EntityBindPropCsReq> _parser = new MessageParser<EntityBindPropCsReq>(() => new EntityBindPropCsReq());

		// Token: 0x04001472 RID: 5234
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001473 RID: 5235
		public const int AGJMAAKNJMMFieldNumber = 1;

		// Token: 0x04001474 RID: 5236
		private bool aGJMAAKNJMM_;

		// Token: 0x04001475 RID: 5237
		public const int MotionFieldNumber = 5;

		// Token: 0x04001476 RID: 5238
		private MotionInfo motion_;
	}
}
