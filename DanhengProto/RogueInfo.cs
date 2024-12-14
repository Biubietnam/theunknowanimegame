using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EA7 RID: 3751
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueInfo : IMessage<RogueInfo>, IMessage, IEquatable<RogueInfo>, IDeepCloneable<RogueInfo>, IBufferMessage
	{
		// Token: 0x17002F55 RID: 12117
		// (get) Token: 0x0600A791 RID: 42897 RVA: 0x001C3437 File Offset: 0x001C1637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueInfo> Parser
		{
			get
			{
				return RogueInfo._parser;
			}
		}

		// Token: 0x17002F56 RID: 12118
		// (get) Token: 0x0600A792 RID: 42898 RVA: 0x001C343E File Offset: 0x001C163E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x0600A793 RID: 42899 RVA: 0x001C3450 File Offset: 0x001C1650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueInfo.Descriptor;
			}
		}

		// Token: 0x0600A794 RID: 42900 RVA: 0x001C3457 File Offset: 0x001C1657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInfo()
		{
		}

		// Token: 0x0600A795 RID: 42901 RVA: 0x001C3460 File Offset: 0x001C1660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInfo(RogueInfo other) : this()
		{
			this.rogueCurrentInfo_ = ((other.rogueCurrentInfo_ != null) ? other.rogueCurrentInfo_.Clone() : null);
			this.rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A796 RID: 42902 RVA: 0x001C34BC File Offset: 0x001C16BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInfo Clone()
		{
			return new RogueInfo(this);
		}

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x0600A797 RID: 42903 RVA: 0x001C34C4 File Offset: 0x001C16C4
		// (set) Token: 0x0600A798 RID: 42904 RVA: 0x001C34CC File Offset: 0x001C16CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCurrentInfo RogueCurrentInfo
		{
			get
			{
				return this.rogueCurrentInfo_;
			}
			set
			{
				this.rogueCurrentInfo_ = value;
			}
		}

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x0600A799 RID: 42905 RVA: 0x001C34D5 File Offset: 0x001C16D5
		// (set) Token: 0x0600A79A RID: 42906 RVA: 0x001C34DD File Offset: 0x001C16DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGetInfo RogueGetInfo
		{
			get
			{
				return this.rogueGetInfo_;
			}
			set
			{
				this.rogueGetInfo_ = value;
			}
		}

		// Token: 0x0600A79B RID: 42907 RVA: 0x001C34E6 File Offset: 0x001C16E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueInfo);
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x001C34F4 File Offset: 0x001C16F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RogueCurrentInfo, other.RogueCurrentInfo) && object.Equals(this.RogueGetInfo, other.RogueGetInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A79D RID: 42909 RVA: 0x001C3548 File Offset: 0x001C1748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueCurrentInfo_ != null)
			{
				num ^= this.RogueCurrentInfo.GetHashCode();
			}
			if (this.rogueGetInfo_ != null)
			{
				num ^= this.RogueGetInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A79E RID: 42910 RVA: 0x001C359A File Offset: 0x001C179A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A79F RID: 42911 RVA: 0x001C35A2 File Offset: 0x001C17A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x001C35AC File Offset: 0x001C17AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueCurrentInfo_ != null)
			{
				output.WriteRawTag(250, 37);
				output.WriteMessage(this.RogueCurrentInfo);
			}
			if (this.rogueGetInfo_ != null)
			{
				output.WriteRawTag(218, 42);
				output.WriteMessage(this.RogueGetInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x001C3610 File Offset: 0x001C1810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueCurrentInfo_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueCurrentInfo);
			}
			if (this.rogueGetInfo_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueGetInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A7A2 RID: 42914 RVA: 0x001C3668 File Offset: 0x001C1868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueCurrentInfo_ != null)
			{
				if (this.rogueCurrentInfo_ == null)
				{
					this.RogueCurrentInfo = new RogueCurrentInfo();
				}
				this.RogueCurrentInfo.MergeFrom(other.RogueCurrentInfo);
			}
			if (other.rogueGetInfo_ != null)
			{
				if (this.rogueGetInfo_ == null)
				{
					this.RogueGetInfo = new RogueGetInfo();
				}
				this.RogueGetInfo.MergeFrom(other.RogueGetInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A7A3 RID: 42915 RVA: 0x001C36E8 File Offset: 0x001C18E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7A4 RID: 42916 RVA: 0x001C36F4 File Offset: 0x001C18F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 4858U)
				{
					if (num != 5466U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueGetInfo_ == null)
						{
							this.RogueGetInfo = new RogueGetInfo();
						}
						input.ReadMessage(this.RogueGetInfo);
					}
				}
				else
				{
					if (this.rogueCurrentInfo_ == null)
					{
						this.RogueCurrentInfo = new RogueCurrentInfo();
					}
					input.ReadMessage(this.RogueCurrentInfo);
				}
			}
		}

		// Token: 0x04004480 RID: 17536
		private static readonly MessageParser<RogueInfo> _parser = new MessageParser<RogueInfo>(() => new RogueInfo());

		// Token: 0x04004481 RID: 17537
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004482 RID: 17538
		public const int RogueCurrentInfoFieldNumber = 607;

		// Token: 0x04004483 RID: 17539
		private RogueCurrentInfo rogueCurrentInfo_;

		// Token: 0x04004484 RID: 17540
		public const int RogueGetInfoFieldNumber = 683;

		// Token: 0x04004485 RID: 17541
		private RogueGetInfo rogueGetInfo_;
	}
}
