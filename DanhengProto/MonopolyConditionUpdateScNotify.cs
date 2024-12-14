using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B1D RID: 2845
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyConditionUpdateScNotify : IMessage<MonopolyConditionUpdateScNotify>, IMessage, IEquatable<MonopolyConditionUpdateScNotify>, IDeepCloneable<MonopolyConditionUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x06007DED RID: 32237 RVA: 0x0014D135 File Offset: 0x0014B335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyConditionUpdateScNotify> Parser
		{
			get
			{
				return MonopolyConditionUpdateScNotify._parser;
			}
		}

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x06007DEE RID: 32238 RVA: 0x0014D13C File Offset: 0x0014B33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyConditionUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x06007DEF RID: 32239 RVA: 0x0014D14E File Offset: 0x0014B34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyConditionUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x06007DF0 RID: 32240 RVA: 0x0014D155 File Offset: 0x0014B355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyConditionUpdateScNotify()
		{
		}

		// Token: 0x06007DF1 RID: 32241 RVA: 0x0014D15D File Offset: 0x0014B35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyConditionUpdateScNotify(MonopolyConditionUpdateScNotify other) : this()
		{
			this.iBJOOCKCFHF_ = ((other.iBJOOCKCFHF_ != null) ? other.iBJOOCKCFHF_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DF2 RID: 32242 RVA: 0x0014D192 File Offset: 0x0014B392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyConditionUpdateScNotify Clone()
		{
			return new MonopolyConditionUpdateScNotify(this);
		}

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x06007DF3 RID: 32243 RVA: 0x0014D19A File Offset: 0x0014B39A
		// (set) Token: 0x06007DF4 RID: 32244 RVA: 0x0014D1A2 File Offset: 0x0014B3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NHMKOHAACCC IBJOOCKCFHF
		{
			get
			{
				return this.iBJOOCKCFHF_;
			}
			set
			{
				this.iBJOOCKCFHF_ = value;
			}
		}

		// Token: 0x06007DF5 RID: 32245 RVA: 0x0014D1AB File Offset: 0x0014B3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyConditionUpdateScNotify);
		}

		// Token: 0x06007DF6 RID: 32246 RVA: 0x0014D1B9 File Offset: 0x0014B3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyConditionUpdateScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.IBJOOCKCFHF, other.IBJOOCKCFHF) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007DF7 RID: 32247 RVA: 0x0014D1EC File Offset: 0x0014B3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.iBJOOCKCFHF_ != null)
			{
				num ^= this.IBJOOCKCFHF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007DF8 RID: 32248 RVA: 0x0014D228 File Offset: 0x0014B428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007DF9 RID: 32249 RVA: 0x0014D230 File Offset: 0x0014B430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DFA RID: 32250 RVA: 0x0014D239 File Offset: 0x0014B439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.iBJOOCKCFHF_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.IBJOOCKCFHF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DFB RID: 32251 RVA: 0x0014D26C File Offset: 0x0014B46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.iBJOOCKCFHF_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IBJOOCKCFHF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007DFC RID: 32252 RVA: 0x0014D2AC File Offset: 0x0014B4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyConditionUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.iBJOOCKCFHF_ != null)
			{
				if (this.iBJOOCKCFHF_ == null)
				{
					this.IBJOOCKCFHF = new NHMKOHAACCC();
				}
				this.IBJOOCKCFHF.MergeFrom(other.IBJOOCKCFHF);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007DFD RID: 32253 RVA: 0x0014D300 File Offset: 0x0014B500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DFE RID: 32254 RVA: 0x0014D30C File Offset: 0x0014B50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.iBJOOCKCFHF_ == null)
					{
						this.IBJOOCKCFHF = new NHMKOHAACCC();
					}
					input.ReadMessage(this.IBJOOCKCFHF);
				}
			}
		}

		// Token: 0x04003054 RID: 12372
		private static readonly MessageParser<MonopolyConditionUpdateScNotify> _parser = new MessageParser<MonopolyConditionUpdateScNotify>(() => new MonopolyConditionUpdateScNotify());

		// Token: 0x04003055 RID: 12373
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003056 RID: 12374
		public const int IBJOOCKCFHFFieldNumber = 14;

		// Token: 0x04003057 RID: 12375
		private NHMKOHAACCC iBJOOCKCFHF_;
	}
}
