using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000555 RID: 1365
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMatch3TurnEndScNotify : IMessage<FightMatch3TurnEndScNotify>, IMessage, IEquatable<FightMatch3TurnEndScNotify>, IDeepCloneable<FightMatch3TurnEndScNotify>, IBufferMessage
	{
		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06003CDC RID: 15580 RVA: 0x000A6D37 File Offset: 0x000A4F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightMatch3TurnEndScNotify> Parser
		{
			get
			{
				return FightMatch3TurnEndScNotify._parser;
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06003CDD RID: 15581 RVA: 0x000A6D3E File Offset: 0x000A4F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightMatch3TurnEndScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06003CDE RID: 15582 RVA: 0x000A6D50 File Offset: 0x000A4F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightMatch3TurnEndScNotify.Descriptor;
			}
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x000A6D57 File Offset: 0x000A4F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3TurnEndScNotify()
		{
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x000A6D60 File Offset: 0x000A4F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3TurnEndScNotify(FightMatch3TurnEndScNotify other) : this()
		{
			this.dKEICJHIDNO_ = ((other.dKEICJHIDNO_ != null) ? other.dKEICJHIDNO_.Clone() : null);
			this.aPOGGHFJJJN_ = ((other.aPOGGHFJJJN_ != null) ? other.aPOGGHFJJJN_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x000A6DBC File Offset: 0x000A4FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3TurnEndScNotify Clone()
		{
			return new FightMatch3TurnEndScNotify(this);
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06003CE2 RID: 15586 RVA: 0x000A6DC4 File Offset: 0x000A4FC4
		// (set) Token: 0x06003CE3 RID: 15587 RVA: 0x000A6DCC File Offset: 0x000A4FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CFHPMBOAHLA DKEICJHIDNO
		{
			get
			{
				return this.dKEICJHIDNO_;
			}
			set
			{
				this.dKEICJHIDNO_ = value;
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06003CE4 RID: 15588 RVA: 0x000A6DD5 File Offset: 0x000A4FD5
		// (set) Token: 0x06003CE5 RID: 15589 RVA: 0x000A6DDD File Offset: 0x000A4FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CFHPMBOAHLA APOGGHFJJJN
		{
			get
			{
				return this.aPOGGHFJJJN_;
			}
			set
			{
				this.aPOGGHFJJJN_ = value;
			}
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x000A6DE6 File Offset: 0x000A4FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightMatch3TurnEndScNotify);
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x000A6DF4 File Offset: 0x000A4FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightMatch3TurnEndScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.DKEICJHIDNO, other.DKEICJHIDNO) && object.Equals(this.APOGGHFJJJN, other.APOGGHFJJJN) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x000A6E48 File Offset: 0x000A5048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dKEICJHIDNO_ != null)
			{
				num ^= this.DKEICJHIDNO.GetHashCode();
			}
			if (this.aPOGGHFJJJN_ != null)
			{
				num ^= this.APOGGHFJJJN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x000A6E9A File Offset: 0x000A509A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x000A6EA2 File Offset: 0x000A50A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x000A6EAC File Offset: 0x000A50AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dKEICJHIDNO_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.DKEICJHIDNO);
			}
			if (this.aPOGGHFJJJN_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.APOGGHFJJJN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x000A6F08 File Offset: 0x000A5108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dKEICJHIDNO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DKEICJHIDNO);
			}
			if (this.aPOGGHFJJJN_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.APOGGHFJJJN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x000A6F60 File Offset: 0x000A5160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightMatch3TurnEndScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.dKEICJHIDNO_ != null)
			{
				if (this.dKEICJHIDNO_ == null)
				{
					this.DKEICJHIDNO = new CFHPMBOAHLA();
				}
				this.DKEICJHIDNO.MergeFrom(other.DKEICJHIDNO);
			}
			if (other.aPOGGHFJJJN_ != null)
			{
				if (this.aPOGGHFJJJN_ == null)
				{
					this.APOGGHFJJJN = new CFHPMBOAHLA();
				}
				this.APOGGHFJJJN.MergeFrom(other.APOGGHFJJJN);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x000A6FE0 File Offset: 0x000A51E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x000A6FEC File Offset: 0x000A51EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.aPOGGHFJJJN_ == null)
						{
							this.APOGGHFJJJN = new CFHPMBOAHLA();
						}
						input.ReadMessage(this.APOGGHFJJJN);
					}
				}
				else
				{
					if (this.dKEICJHIDNO_ == null)
					{
						this.DKEICJHIDNO = new CFHPMBOAHLA();
					}
					input.ReadMessage(this.DKEICJHIDNO);
				}
			}
		}

		// Token: 0x04001869 RID: 6249
		private static readonly MessageParser<FightMatch3TurnEndScNotify> _parser = new MessageParser<FightMatch3TurnEndScNotify>(() => new FightMatch3TurnEndScNotify());

		// Token: 0x0400186A RID: 6250
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400186B RID: 6251
		public const int DKEICJHIDNOFieldNumber = 10;

		// Token: 0x0400186C RID: 6252
		private CFHPMBOAHLA dKEICJHIDNO_;

		// Token: 0x0400186D RID: 6253
		public const int APOGGHFJJJNFieldNumber = 14;

		// Token: 0x0400186E RID: 6254
		private CFHPMBOAHLA aPOGGHFJJJN_;
	}
}
