using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000927 RID: 2343
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IKENAAJDAFF : IMessage<IKENAAJDAFF>, IMessage, IEquatable<IKENAAJDAFF>, IDeepCloneable<IKENAAJDAFF>, IBufferMessage
	{
		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x06006886 RID: 26758 RVA: 0x001172C3 File Offset: 0x001154C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IKENAAJDAFF> Parser
		{
			get
			{
				return IKENAAJDAFF._parser;
			}
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x06006887 RID: 26759 RVA: 0x001172CA File Offset: 0x001154CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IKENAAJDAFFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x06006888 RID: 26760 RVA: 0x001172DC File Offset: 0x001154DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IKENAAJDAFF.Descriptor;
			}
		}

		// Token: 0x06006889 RID: 26761 RVA: 0x001172E3 File Offset: 0x001154E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IKENAAJDAFF()
		{
		}

		// Token: 0x0600688A RID: 26762 RVA: 0x001172EC File Offset: 0x001154EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IKENAAJDAFF(IKENAAJDAFF other) : this()
		{
			this.rotateInfo_ = ((other.rotateInfo_ != null) ? other.rotateInfo_.Clone() : null);
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600688B RID: 26763 RVA: 0x00117364 File Offset: 0x00115564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IKENAAJDAFF Clone()
		{
			return new IKENAAJDAFF(this);
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x0600688C RID: 26764 RVA: 0x0011736C File Offset: 0x0011556C
		// (set) Token: 0x0600688D RID: 26765 RVA: 0x00117374 File Offset: 0x00115574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMapRotateInfo RotateInfo
		{
			get
			{
				return this.rotateInfo_;
			}
			set
			{
				this.rotateInfo_ = value;
			}
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x0600688E RID: 26766 RVA: 0x0011737D File Offset: 0x0011557D
		// (set) Token: 0x0600688F RID: 26767 RVA: 0x00117385 File Offset: 0x00115585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupInfo Lineup
		{
			get
			{
				return this.lineup_;
			}
			set
			{
				this.lineup_ = value;
			}
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x06006890 RID: 26768 RVA: 0x0011738E File Offset: 0x0011558E
		// (set) Token: 0x06006891 RID: 26769 RVA: 0x00117396 File Offset: 0x00115596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInfo Scene
		{
			get
			{
				return this.scene_;
			}
			set
			{
				this.scene_ = value;
			}
		}

		// Token: 0x06006892 RID: 26770 RVA: 0x0011739F File Offset: 0x0011559F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IKENAAJDAFF);
		}

		// Token: 0x06006893 RID: 26771 RVA: 0x001173B0 File Offset: 0x001155B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IKENAAJDAFF other)
		{
			return other != null && (other == this || (object.Equals(this.RotateInfo, other.RotateInfo) && object.Equals(this.Lineup, other.Lineup) && object.Equals(this.Scene, other.Scene) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006894 RID: 26772 RVA: 0x00117418 File Offset: 0x00115618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rotateInfo_ != null)
			{
				num ^= this.RotateInfo.GetHashCode();
			}
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006895 RID: 26773 RVA: 0x00117480 File Offset: 0x00115680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006896 RID: 26774 RVA: 0x00117488 File Offset: 0x00115688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006897 RID: 26775 RVA: 0x00117494 File Offset: 0x00115694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.scene_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Scene);
			}
			if (this.rotateInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RotateInfo);
			}
			if (this.lineup_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Lineup);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006898 RID: 26776 RVA: 0x0011750C File Offset: 0x0011570C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rotateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RotateInfo);
			}
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006899 RID: 26777 RVA: 0x0011757C File Offset: 0x0011577C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IKENAAJDAFF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rotateInfo_ != null)
			{
				if (this.rotateInfo_ == null)
				{
					this.RotateInfo = new RogueMapRotateInfo();
				}
				this.RotateInfo.MergeFrom(other.RotateInfo);
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new LineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new SceneInfo();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600689A RID: 26778 RVA: 0x00117628 File Offset: 0x00115828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600689B RID: 26779 RVA: 0x00117634 File Offset: 0x00115834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 42U)
					{
						if (num != 74U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.lineup_ == null)
							{
								this.Lineup = new LineupInfo();
							}
							input.ReadMessage(this.Lineup);
						}
					}
					else
					{
						if (this.rotateInfo_ == null)
						{
							this.RotateInfo = new RogueMapRotateInfo();
						}
						input.ReadMessage(this.RotateInfo);
					}
				}
				else
				{
					if (this.scene_ == null)
					{
						this.Scene = new SceneInfo();
					}
					input.ReadMessage(this.Scene);
				}
			}
		}

		// Token: 0x0400281A RID: 10266
		private static readonly MessageParser<IKENAAJDAFF> _parser = new MessageParser<IKENAAJDAFF>(() => new IKENAAJDAFF());

		// Token: 0x0400281B RID: 10267
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400281C RID: 10268
		public const int RotateInfoFieldNumber = 5;

		// Token: 0x0400281D RID: 10269
		private RogueMapRotateInfo rotateInfo_;

		// Token: 0x0400281E RID: 10270
		public const int LineupFieldNumber = 9;

		// Token: 0x0400281F RID: 10271
		private LineupInfo lineup_;

		// Token: 0x04002820 RID: 10272
		public const int SceneFieldNumber = 1;

		// Token: 0x04002821 RID: 10273
		private SceneInfo scene_;
	}
}
