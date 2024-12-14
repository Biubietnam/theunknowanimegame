using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EB9 RID: 3769
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicCurSceneInfo : IMessage<RogueMagicCurSceneInfo>, IMessage, IEquatable<RogueMagicCurSceneInfo>, IDeepCloneable<RogueMagicCurSceneInfo>, IBufferMessage
	{
		// Token: 0x17002F95 RID: 12181
		// (get) Token: 0x0600A86E RID: 43118 RVA: 0x001C5D7F File Offset: 0x001C3F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicCurSceneInfo> Parser
		{
			get
			{
				return RogueMagicCurSceneInfo._parser;
			}
		}

		// Token: 0x17002F96 RID: 12182
		// (get) Token: 0x0600A86F RID: 43119 RVA: 0x001C5D86 File Offset: 0x001C3F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicCurSceneInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F97 RID: 12183
		// (get) Token: 0x0600A870 RID: 43120 RVA: 0x001C5D98 File Offset: 0x001C3F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicCurSceneInfo.Descriptor;
			}
		}

		// Token: 0x0600A871 RID: 43121 RVA: 0x001C5D9F File Offset: 0x001C3F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicCurSceneInfo()
		{
		}

		// Token: 0x0600A872 RID: 43122 RVA: 0x001C5DA8 File Offset: 0x001C3FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicCurSceneInfo(RogueMagicCurSceneInfo other) : this()
		{
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this.rotateInfo_ = ((other.rotateInfo_ != null) ? other.rotateInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A873 RID: 43123 RVA: 0x001C5E20 File Offset: 0x001C4020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicCurSceneInfo Clone()
		{
			return new RogueMagicCurSceneInfo(this);
		}

		// Token: 0x17002F98 RID: 12184
		// (get) Token: 0x0600A874 RID: 43124 RVA: 0x001C5E28 File Offset: 0x001C4028
		// (set) Token: 0x0600A875 RID: 43125 RVA: 0x001C5E30 File Offset: 0x001C4030
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

		// Token: 0x17002F99 RID: 12185
		// (get) Token: 0x0600A876 RID: 43126 RVA: 0x001C5E39 File Offset: 0x001C4039
		// (set) Token: 0x0600A877 RID: 43127 RVA: 0x001C5E41 File Offset: 0x001C4041
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

		// Token: 0x17002F9A RID: 12186
		// (get) Token: 0x0600A878 RID: 43128 RVA: 0x001C5E4A File Offset: 0x001C404A
		// (set) Token: 0x0600A879 RID: 43129 RVA: 0x001C5E52 File Offset: 0x001C4052
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

		// Token: 0x0600A87A RID: 43130 RVA: 0x001C5E5B File Offset: 0x001C405B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicCurSceneInfo);
		}

		// Token: 0x0600A87B RID: 43131 RVA: 0x001C5E6C File Offset: 0x001C406C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicCurSceneInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Scene, other.Scene) && object.Equals(this.Lineup, other.Lineup) && object.Equals(this.RotateInfo, other.RotateInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A87C RID: 43132 RVA: 0x001C5ED4 File Offset: 0x001C40D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this.rotateInfo_ != null)
			{
				num ^= this.RotateInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A87D RID: 43133 RVA: 0x001C5F3C File Offset: 0x001C413C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A87E RID: 43134 RVA: 0x001C5F44 File Offset: 0x001C4144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A87F RID: 43135 RVA: 0x001C5F50 File Offset: 0x001C4150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rotateInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RotateInfo);
			}
			if (this.lineup_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Lineup);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Scene);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A880 RID: 43136 RVA: 0x001C5FC8 File Offset: 0x001C41C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this.rotateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RotateInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A881 RID: 43137 RVA: 0x001C6038 File Offset: 0x001C4238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicCurSceneInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new SceneInfo();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new LineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			if (other.rotateInfo_ != null)
			{
				if (this.rotateInfo_ == null)
				{
					this.RotateInfo = new RogueMapRotateInfo();
				}
				this.RotateInfo.MergeFrom(other.RotateInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A882 RID: 43138 RVA: 0x001C60E4 File Offset: 0x001C42E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A883 RID: 43139 RVA: 0x001C60F0 File Offset: 0x001C42F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 114U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
		}

		// Token: 0x040044D9 RID: 17625
		private static readonly MessageParser<RogueMagicCurSceneInfo> _parser = new MessageParser<RogueMagicCurSceneInfo>(() => new RogueMagicCurSceneInfo());

		// Token: 0x040044DA RID: 17626
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044DB RID: 17627
		public const int SceneFieldNumber = 15;

		// Token: 0x040044DC RID: 17628
		private SceneInfo scene_;

		// Token: 0x040044DD RID: 17629
		public const int LineupFieldNumber = 14;

		// Token: 0x040044DE RID: 17630
		private LineupInfo lineup_;

		// Token: 0x040044DF RID: 17631
		public const int RotateInfoFieldNumber = 6;

		// Token: 0x040044E0 RID: 17632
		private RogueMapRotateInfo rotateInfo_;
	}
}
