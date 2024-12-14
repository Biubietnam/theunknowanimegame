using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F91 RID: 3985
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournCurSceneInfo : IMessage<RogueTournCurSceneInfo>, IMessage, IEquatable<RogueTournCurSceneInfo>, IDeepCloneable<RogueTournCurSceneInfo>, IBufferMessage
	{
		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x0600B190 RID: 45456 RVA: 0x001DD757 File Offset: 0x001DB957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournCurSceneInfo> Parser
		{
			get
			{
				return RogueTournCurSceneInfo._parser;
			}
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x0600B191 RID: 45457 RVA: 0x001DD75E File Offset: 0x001DB95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournCurSceneInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0600B192 RID: 45458 RVA: 0x001DD770 File Offset: 0x001DB970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournCurSceneInfo.Descriptor;
			}
		}

		// Token: 0x0600B193 RID: 45459 RVA: 0x001DD777 File Offset: 0x001DB977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurSceneInfo()
		{
		}

		// Token: 0x0600B194 RID: 45460 RVA: 0x001DD780 File Offset: 0x001DB980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurSceneInfo(RogueTournCurSceneInfo other) : this()
		{
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.rotateInfo_ = ((other.rotateInfo_ != null) ? other.rotateInfo_.Clone() : null);
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B195 RID: 45461 RVA: 0x001DD7F8 File Offset: 0x001DB9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurSceneInfo Clone()
		{
			return new RogueTournCurSceneInfo(this);
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0600B196 RID: 45462 RVA: 0x001DD800 File Offset: 0x001DBA00
		// (set) Token: 0x0600B197 RID: 45463 RVA: 0x001DD808 File Offset: 0x001DBA08
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

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x0600B198 RID: 45464 RVA: 0x001DD811 File Offset: 0x001DBA11
		// (set) Token: 0x0600B199 RID: 45465 RVA: 0x001DD819 File Offset: 0x001DBA19
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

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x0600B19A RID: 45466 RVA: 0x001DD822 File Offset: 0x001DBA22
		// (set) Token: 0x0600B19B RID: 45467 RVA: 0x001DD82A File Offset: 0x001DBA2A
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

		// Token: 0x0600B19C RID: 45468 RVA: 0x001DD833 File Offset: 0x001DBA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournCurSceneInfo);
		}

		// Token: 0x0600B19D RID: 45469 RVA: 0x001DD844 File Offset: 0x001DBA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournCurSceneInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Scene, other.Scene) && object.Equals(this.RotateInfo, other.RotateInfo) && object.Equals(this.Lineup, other.Lineup) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B19E RID: 45470 RVA: 0x001DD8AC File Offset: 0x001DBAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this.rotateInfo_ != null)
			{
				num ^= this.RotateInfo.GetHashCode();
			}
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B19F RID: 45471 RVA: 0x001DD914 File Offset: 0x001DBB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B1A0 RID: 45472 RVA: 0x001DD91C File Offset: 0x001DBB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1A1 RID: 45473 RVA: 0x001DD928 File Offset: 0x001DBB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rotateInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RotateInfo);
			}
			if (this.lineup_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Lineup);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Scene);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B1A2 RID: 45474 RVA: 0x001DD9A0 File Offset: 0x001DBBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this.rotateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RotateInfo);
			}
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B1A3 RID: 45475 RVA: 0x001DDA10 File Offset: 0x001DBC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournCurSceneInfo other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B1A4 RID: 45476 RVA: 0x001DDABC File Offset: 0x001DBCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1A5 RID: 45477 RVA: 0x001DDAC8 File Offset: 0x001DBCC8
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
						if (num != 58U)
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

		// Token: 0x04004841 RID: 18497
		private static readonly MessageParser<RogueTournCurSceneInfo> _parser = new MessageParser<RogueTournCurSceneInfo>(() => new RogueTournCurSceneInfo());

		// Token: 0x04004842 RID: 18498
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004843 RID: 18499
		public const int SceneFieldNumber = 7;

		// Token: 0x04004844 RID: 18500
		private SceneInfo scene_;

		// Token: 0x04004845 RID: 18501
		public const int RotateInfoFieldNumber = 1;

		// Token: 0x04004846 RID: 18502
		private RogueMapRotateInfo rotateInfo_;

		// Token: 0x04004847 RID: 18503
		public const int LineupFieldNumber = 5;

		// Token: 0x04004848 RID: 18504
		private LineupInfo lineup_;
	}
}
