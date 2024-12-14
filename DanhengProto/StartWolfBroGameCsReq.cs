using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011DD RID: 4573
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartWolfBroGameCsReq : IMessage<StartWolfBroGameCsReq>, IMessage, IEquatable<StartWolfBroGameCsReq>, IDeepCloneable<StartWolfBroGameCsReq>, IBufferMessage
	{
		// Token: 0x170039A9 RID: 14761
		// (get) Token: 0x0600CC69 RID: 52329 RVA: 0x00224977 File Offset: 0x00222B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartWolfBroGameCsReq> Parser
		{
			get
			{
				return StartWolfBroGameCsReq._parser;
			}
		}

		// Token: 0x170039AA RID: 14762
		// (get) Token: 0x0600CC6A RID: 52330 RVA: 0x0022497E File Offset: 0x00222B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartWolfBroGameCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039AB RID: 14763
		// (get) Token: 0x0600CC6B RID: 52331 RVA: 0x00224990 File Offset: 0x00222B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartWolfBroGameCsReq.Descriptor;
			}
		}

		// Token: 0x0600CC6C RID: 52332 RVA: 0x00224997 File Offset: 0x00222B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartWolfBroGameCsReq()
		{
		}

		// Token: 0x0600CC6D RID: 52333 RVA: 0x002249A0 File Offset: 0x00222BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartWolfBroGameCsReq(StartWolfBroGameCsReq other) : this()
		{
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this.id_ = other.id_;
			this.groupStateInfo_ = ((other.groupStateInfo_ != null) ? other.groupStateInfo_.Clone() : null);
			this.jMAPEPGLENN_ = other.jMAPEPGLENN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC6E RID: 52334 RVA: 0x00224A14 File Offset: 0x00222C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartWolfBroGameCsReq Clone()
		{
			return new StartWolfBroGameCsReq(this);
		}

		// Token: 0x170039AC RID: 14764
		// (get) Token: 0x0600CC6F RID: 52335 RVA: 0x00224A1C File Offset: 0x00222C1C
		// (set) Token: 0x0600CC70 RID: 52336 RVA: 0x00224A24 File Offset: 0x00222C24
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

		// Token: 0x170039AD RID: 14765
		// (get) Token: 0x0600CC71 RID: 52337 RVA: 0x00224A2D File Offset: 0x00222C2D
		// (set) Token: 0x0600CC72 RID: 52338 RVA: 0x00224A35 File Offset: 0x00222C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x0600CC73 RID: 52339 RVA: 0x00224A3E File Offset: 0x00222C3E
		// (set) Token: 0x0600CC74 RID: 52340 RVA: 0x00224A46 File Offset: 0x00222C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateInfo GroupStateInfo
		{
			get
			{
				return this.groupStateInfo_;
			}
			set
			{
				this.groupStateInfo_ = value;
			}
		}

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x0600CC75 RID: 52341 RVA: 0x00224A4F File Offset: 0x00222C4F
		// (set) Token: 0x0600CC76 RID: 52342 RVA: 0x00224A57 File Offset: 0x00222C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JMAPEPGLENN
		{
			get
			{
				return this.jMAPEPGLENN_;
			}
			set
			{
				this.jMAPEPGLENN_ = value;
			}
		}

		// Token: 0x0600CC77 RID: 52343 RVA: 0x00224A60 File Offset: 0x00222C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartWolfBroGameCsReq);
		}

		// Token: 0x0600CC78 RID: 52344 RVA: 0x00224A70 File Offset: 0x00222C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartWolfBroGameCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.Motion, other.Motion) && this.Id == other.Id && object.Equals(this.GroupStateInfo, other.GroupStateInfo) && this.JMAPEPGLENN == other.JMAPEPGLENN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC79 RID: 52345 RVA: 0x00224AE4 File Offset: 0x00222CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.motion_ != null)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.groupStateInfo_ != null)
			{
				num ^= this.GroupStateInfo.GetHashCode();
			}
			if (this.JMAPEPGLENN)
			{
				num ^= this.JMAPEPGLENN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CC7A RID: 52346 RVA: 0x00224B68 File Offset: 0x00222D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CC7B RID: 52347 RVA: 0x00224B70 File Offset: 0x00222D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC7C RID: 52348 RVA: 0x00224B7C File Offset: 0x00222D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Id);
			}
			if (this.groupStateInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.GroupStateInfo);
			}
			if (this.JMAPEPGLENN)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.JMAPEPGLENN);
			}
			if (this.motion_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Motion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC7D RID: 52349 RVA: 0x00224C10 File Offset: 0x00222E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.motion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motion);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.groupStateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GroupStateInfo);
			}
			if (this.JMAPEPGLENN)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CC7E RID: 52350 RVA: 0x00224C8C File Offset: 0x00222E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartWolfBroGameCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.motion_ != null)
			{
				if (this.motion_ == null)
				{
					this.Motion = new MotionInfo();
				}
				this.Motion.MergeFrom(other.Motion);
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.groupStateInfo_ != null)
			{
				if (this.groupStateInfo_ == null)
				{
					this.GroupStateInfo = new GroupStateInfo();
				}
				this.GroupStateInfo.MergeFrom(other.GroupStateInfo);
			}
			if (other.JMAPEPGLENN)
			{
				this.JMAPEPGLENN = other.JMAPEPGLENN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CC7F RID: 52351 RVA: 0x00224D34 File Offset: 0x00222F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC80 RID: 52352 RVA: 0x00224D40 File Offset: 0x00222F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 32U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.groupStateInfo_ == null)
						{
							this.GroupStateInfo = new GroupStateInfo();
						}
						input.ReadMessage(this.GroupStateInfo);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.JMAPEPGLENN = input.ReadBool();
						continue;
					}
					if (num == 82U)
					{
						if (this.motion_ == null)
						{
							this.Motion = new MotionInfo();
						}
						input.ReadMessage(this.Motion);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400526B RID: 21099
		private static readonly MessageParser<StartWolfBroGameCsReq> _parser = new MessageParser<StartWolfBroGameCsReq>(() => new StartWolfBroGameCsReq());

		// Token: 0x0400526C RID: 21100
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400526D RID: 21101
		public const int MotionFieldNumber = 10;

		// Token: 0x0400526E RID: 21102
		private MotionInfo motion_;

		// Token: 0x0400526F RID: 21103
		public const int IdFieldNumber = 4;

		// Token: 0x04005270 RID: 21104
		private uint id_;

		// Token: 0x04005271 RID: 21105
		public const int GroupStateInfoFieldNumber = 5;

		// Token: 0x04005272 RID: 21106
		private GroupStateInfo groupStateInfo_;

		// Token: 0x04005273 RID: 21107
		public const int JMAPEPGLENNFieldNumber = 8;

		// Token: 0x04005274 RID: 21108
		private bool jMAPEPGLENN_;
	}
}
