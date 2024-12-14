using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BD7 RID: 3031
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicData : IMessage<MusicData>, IMessage, IEquatable<MusicData>, IDeepCloneable<MusicData>, IBufferMessage
	{
		// Token: 0x1700259A RID: 9626
		// (get) Token: 0x0600861C RID: 34332 RVA: 0x00161F3C File Offset: 0x0016013C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicData> Parser
		{
			get
			{
				return MusicData._parser;
			}
		}

		// Token: 0x1700259B RID: 9627
		// (get) Token: 0x0600861D RID: 34333 RVA: 0x00161F43 File Offset: 0x00160143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700259C RID: 9628
		// (get) Token: 0x0600861E RID: 34334 RVA: 0x00161F55 File Offset: 0x00160155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicData.Descriptor;
			}
		}

		// Token: 0x0600861F RID: 34335 RVA: 0x00161F5C File Offset: 0x0016015C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicData()
		{
		}

		// Token: 0x06008620 RID: 34336 RVA: 0x00161F64 File Offset: 0x00160164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicData(MusicData other) : this()
		{
			this.isPlayed_ = other.isPlayed_;
			this.id_ = other.id_;
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008621 RID: 34337 RVA: 0x00161FA1 File Offset: 0x001601A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicData Clone()
		{
			return new MusicData(this);
		}

		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x06008622 RID: 34338 RVA: 0x00161FA9 File Offset: 0x001601A9
		// (set) Token: 0x06008623 RID: 34339 RVA: 0x00161FB1 File Offset: 0x001601B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPlayed
		{
			get
			{
				return this.isPlayed_;
			}
			set
			{
				this.isPlayed_ = value;
			}
		}

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x06008624 RID: 34340 RVA: 0x00161FBA File Offset: 0x001601BA
		// (set) Token: 0x06008625 RID: 34341 RVA: 0x00161FC2 File Offset: 0x001601C2
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

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x06008626 RID: 34342 RVA: 0x00161FCB File Offset: 0x001601CB
		// (set) Token: 0x06008627 RID: 34343 RVA: 0x00161FD3 File Offset: 0x001601D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x06008628 RID: 34344 RVA: 0x00161FDC File Offset: 0x001601DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicData);
		}

		// Token: 0x06008629 RID: 34345 RVA: 0x00161FEC File Offset: 0x001601EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicData other)
		{
			return other != null && (other == this || (this.IsPlayed == other.IsPlayed && this.Id == other.Id && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600862A RID: 34346 RVA: 0x00162048 File Offset: 0x00160248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsPlayed)
			{
				num ^= this.IsPlayed.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600862B RID: 34347 RVA: 0x001620B9 File Offset: 0x001602B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600862C RID: 34348 RVA: 0x001620C1 File Offset: 0x001602C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600862D RID: 34349 RVA: 0x001620CC File Offset: 0x001602CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsPlayed)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsPlayed);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.GroupId);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600862E RID: 34350 RVA: 0x00162144 File Offset: 0x00160344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsPlayed)
			{
				num += 2;
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600862F RID: 34351 RVA: 0x001621A8 File Offset: 0x001603A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsPlayed)
			{
				this.IsPlayed = other.IsPlayed;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008630 RID: 34352 RVA: 0x0016220C File Offset: 0x0016040C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008631 RID: 34353 RVA: 0x00162218 File Offset: 0x00160418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 64U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Id = input.ReadUInt32();
						}
					}
					else
					{
						this.GroupId = input.ReadUInt32();
					}
				}
				else
				{
					this.IsPlayed = input.ReadBool();
				}
			}
		}

		// Token: 0x0400335B RID: 13147
		private static readonly MessageParser<MusicData> _parser = new MessageParser<MusicData>(() => new MusicData());

		// Token: 0x0400335C RID: 13148
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400335D RID: 13149
		public const int IsPlayedFieldNumber = 4;

		// Token: 0x0400335E RID: 13150
		private bool isPlayed_;

		// Token: 0x0400335F RID: 13151
		public const int IdFieldNumber = 11;

		// Token: 0x04003360 RID: 13152
		private uint id_;

		// Token: 0x04003361 RID: 13153
		public const int GroupIdFieldNumber = 8;

		// Token: 0x04003362 RID: 13154
		private uint groupId_;
	}
}
