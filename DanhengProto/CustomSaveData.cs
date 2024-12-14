using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000343 RID: 835
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CustomSaveData : IMessage<CustomSaveData>, IMessage, IEquatable<CustomSaveData>, IDeepCloneable<CustomSaveData>, IBufferMessage
	{
		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06002558 RID: 9560 RVA: 0x000695D4 File Offset: 0x000677D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CustomSaveData> Parser
		{
			get
			{
				return CustomSaveData._parser;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x000695DB File Offset: 0x000677DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CustomSaveDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x000695ED File Offset: 0x000677ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CustomSaveData.Descriptor;
			}
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x000695F4 File Offset: 0x000677F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CustomSaveData()
		{
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00069607 File Offset: 0x00067807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CustomSaveData(CustomSaveData other) : this()
		{
			this.groupId_ = other.groupId_;
			this.saveData_ = other.saveData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00069638 File Offset: 0x00067838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CustomSaveData Clone()
		{
			return new CustomSaveData(this);
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x00069640 File Offset: 0x00067840
		// (set) Token: 0x0600255F RID: 9567 RVA: 0x00069648 File Offset: 0x00067848
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

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x00069651 File Offset: 0x00067851
		// (set) Token: 0x06002561 RID: 9569 RVA: 0x00069659 File Offset: 0x00067859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SaveData
		{
			get
			{
				return this.saveData_;
			}
			set
			{
				this.saveData_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x0006966C File Offset: 0x0006786C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CustomSaveData);
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x0006967C File Offset: 0x0006787C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CustomSaveData other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && !(this.SaveData != other.SaveData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x000696CC File Offset: 0x000678CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.SaveData.Length != 0)
			{
				num ^= this.SaveData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x00069726 File Offset: 0x00067926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x0006972E File Offset: 0x0006792E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x00069738 File Offset: 0x00067938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GroupId);
			}
			if (this.SaveData.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.SaveData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x00069798 File Offset: 0x00067998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.SaveData.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SaveData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x000697F4 File Offset: 0x000679F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CustomSaveData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.SaveData.Length != 0)
			{
				this.SaveData = other.SaveData;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x00069849 File Offset: 0x00067A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x00069854 File Offset: 0x00067A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SaveData = input.ReadString();
					}
				}
				else
				{
					this.GroupId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000F34 RID: 3892
		private static readonly MessageParser<CustomSaveData> _parser = new MessageParser<CustomSaveData>(() => new CustomSaveData());

		// Token: 0x04000F35 RID: 3893
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F36 RID: 3894
		public const int GroupIdFieldNumber = 3;

		// Token: 0x04000F37 RID: 3895
		private uint groupId_;

		// Token: 0x04000F38 RID: 3896
		public const int SaveDataFieldNumber = 13;

		// Token: 0x04000F39 RID: 3897
		private string saveData_ = "";
	}
}
