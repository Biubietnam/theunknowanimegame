using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005E3 RID: 1507
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameplayCounterUpdateScNotify : IMessage<GameplayCounterUpdateScNotify>, IMessage, IEquatable<GameplayCounterUpdateScNotify>, IDeepCloneable<GameplayCounterUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06004335 RID: 17205 RVA: 0x000B6E9B File Offset: 0x000B509B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameplayCounterUpdateScNotify> Parser
		{
			get
			{
				return GameplayCounterUpdateScNotify._parser;
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06004336 RID: 17206 RVA: 0x000B6EA2 File Offset: 0x000B50A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameplayCounterUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06004337 RID: 17207 RVA: 0x000B6EB4 File Offset: 0x000B50B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayCounterUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x000B6EBB File Offset: 0x000B50BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterUpdateScNotify()
		{
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x000B6EC3 File Offset: 0x000B50C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterUpdateScNotify(GameplayCounterUpdateScNotify other) : this()
		{
			this.nNCFPDLCNHN_ = other.nNCFPDLCNHN_;
			this.gEEJPHNHHOD_ = other.gEEJPHNHHOD_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x000B6F00 File Offset: 0x000B5100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterUpdateScNotify Clone()
		{
			return new GameplayCounterUpdateScNotify(this);
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x0600433B RID: 17211 RVA: 0x000B6F08 File Offset: 0x000B5108
		// (set) Token: 0x0600433C RID: 17212 RVA: 0x000B6F10 File Offset: 0x000B5110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NNCFPDLCNHN
		{
			get
			{
				return this.nNCFPDLCNHN_;
			}
			set
			{
				this.nNCFPDLCNHN_ = value;
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x0600433D RID: 17213 RVA: 0x000B6F19 File Offset: 0x000B5119
		// (set) Token: 0x0600433E RID: 17214 RVA: 0x000B6F21 File Offset: 0x000B5121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GEEJPHNHHOD
		{
			get
			{
				return this.gEEJPHNHHOD_;
			}
			set
			{
				this.gEEJPHNHHOD_ = value;
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x0600433F RID: 17215 RVA: 0x000B6F2A File Offset: 0x000B512A
		// (set) Token: 0x06004340 RID: 17216 RVA: 0x000B6F32 File Offset: 0x000B5132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterUpdateReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x000B6F3B File Offset: 0x000B513B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayCounterUpdateScNotify);
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x000B6F4C File Offset: 0x000B514C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayCounterUpdateScNotify other)
		{
			return other != null && (other == this || (this.NNCFPDLCNHN == other.NNCFPDLCNHN && this.GEEJPHNHHOD == other.GEEJPHNHHOD && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x000B6FA8 File Offset: 0x000B51A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NNCFPDLCNHN != 0U)
			{
				num ^= this.NNCFPDLCNHN.GetHashCode();
			}
			if (this.GEEJPHNHHOD != 0U)
			{
				num ^= this.GEEJPHNHHOD.GetHashCode();
			}
			if (this.Reason != GameplayCounterUpdateReason.None)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x000B701F File Offset: 0x000B521F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x000B7027 File Offset: 0x000B5227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x000B7030 File Offset: 0x000B5230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != GameplayCounterUpdateReason.None)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Reason);
			}
			if (this.GEEJPHNHHOD != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.GEEJPHNHHOD);
			}
			if (this.NNCFPDLCNHN != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.NNCFPDLCNHN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x000B70A8 File Offset: 0x000B52A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NNCFPDLCNHN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NNCFPDLCNHN);
			}
			if (this.GEEJPHNHHOD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GEEJPHNHHOD);
			}
			if (this.Reason != GameplayCounterUpdateReason.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x000B7118 File Offset: 0x000B5318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayCounterUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NNCFPDLCNHN != 0U)
			{
				this.NNCFPDLCNHN = other.NNCFPDLCNHN;
			}
			if (other.GEEJPHNHHOD != 0U)
			{
				this.GEEJPHNHHOD = other.GEEJPHNHHOD;
			}
			if (other.Reason != GameplayCounterUpdateReason.None)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x000B717C File Offset: 0x000B537C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x000B7188 File Offset: 0x000B5388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 32U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NNCFPDLCNHN = input.ReadUInt32();
						}
					}
					else
					{
						this.GEEJPHNHHOD = input.ReadUInt32();
					}
				}
				else
				{
					this.Reason = (GameplayCounterUpdateReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x04001AAD RID: 6829
		private static readonly MessageParser<GameplayCounterUpdateScNotify> _parser = new MessageParser<GameplayCounterUpdateScNotify>(() => new GameplayCounterUpdateScNotify());

		// Token: 0x04001AAE RID: 6830
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AAF RID: 6831
		public const int NNCFPDLCNHNFieldNumber = 12;

		// Token: 0x04001AB0 RID: 6832
		private uint nNCFPDLCNHN_;

		// Token: 0x04001AB1 RID: 6833
		public const int GEEJPHNHHODFieldNumber = 4;

		// Token: 0x04001AB2 RID: 6834
		private uint gEEJPHNHHOD_;

		// Token: 0x04001AB3 RID: 6835
		public const int ReasonFieldNumber = 3;

		// Token: 0x04001AB4 RID: 6836
		private GameplayCounterUpdateReason reason_;
	}
}
