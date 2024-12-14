using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200106B RID: 4203
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneEntityRefreshInfo : IMessage<SceneEntityRefreshInfo>, IMessage, IEquatable<SceneEntityRefreshInfo>, IDeepCloneable<SceneEntityRefreshInfo>, IBufferMessage
	{
		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x0600BB2C RID: 47916 RVA: 0x001F77D4 File Offset: 0x001F59D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneEntityRefreshInfo> Parser
		{
			get
			{
				return SceneEntityRefreshInfo._parser;
			}
		}

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x0600BB2D RID: 47917 RVA: 0x001F77DB File Offset: 0x001F59DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneEntityRefreshInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170034CE RID: 13518
		// (get) Token: 0x0600BB2E RID: 47918 RVA: 0x001F77ED File Offset: 0x001F59ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneEntityRefreshInfo.Descriptor;
			}
		}

		// Token: 0x0600BB2F RID: 47919 RVA: 0x001F77F4 File Offset: 0x001F59F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityRefreshInfo()
		{
		}

		// Token: 0x0600BB30 RID: 47920 RVA: 0x001F77FC File Offset: 0x001F59FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityRefreshInfo(SceneEntityRefreshInfo other) : this()
		{
			SceneEntityRefreshInfo.RefreshOneofCase refreshCase = other.RefreshCase;
			if (refreshCase != SceneEntityRefreshInfo.RefreshOneofCase.AddEntity)
			{
				if (refreshCase != SceneEntityRefreshInfo.RefreshOneofCase.FIFLLOGPNMC)
				{
					if (refreshCase == SceneEntityRefreshInfo.RefreshOneofCase.DeleteEntity)
					{
						this.DeleteEntity = other.DeleteEntity;
					}
				}
				else
				{
					this.FIFLLOGPNMC = other.FIFLLOGPNMC;
				}
			}
			else
			{
				this.AddEntity = other.AddEntity.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB31 RID: 47921 RVA: 0x001F7864 File Offset: 0x001F5A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityRefreshInfo Clone()
		{
			return new SceneEntityRefreshInfo(this);
		}

		// Token: 0x170034CF RID: 13519
		// (get) Token: 0x0600BB32 RID: 47922 RVA: 0x001F786C File Offset: 0x001F5A6C
		// (set) Token: 0x0600BB33 RID: 47923 RVA: 0x001F7884 File Offset: 0x001F5A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityInfo AddEntity
		{
			get
			{
				if (this.refreshCase_ != SceneEntityRefreshInfo.RefreshOneofCase.AddEntity)
				{
					return null;
				}
				return (SceneEntityInfo)this.refresh_;
			}
			set
			{
				this.refresh_ = value;
				this.refreshCase_ = ((value == null) ? SceneEntityRefreshInfo.RefreshOneofCase.None : SceneEntityRefreshInfo.RefreshOneofCase.AddEntity);
			}
		}

		// Token: 0x170034D0 RID: 13520
		// (get) Token: 0x0600BB34 RID: 47924 RVA: 0x001F789A File Offset: 0x001F5A9A
		// (set) Token: 0x0600BB35 RID: 47925 RVA: 0x001F78B1 File Offset: 0x001F5AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FIFLLOGPNMC
		{
			get
			{
				if (!this.HasFIFLLOGPNMC)
				{
					return 0U;
				}
				return (uint)this.refresh_;
			}
			set
			{
				this.refresh_ = value;
				this.refreshCase_ = SceneEntityRefreshInfo.RefreshOneofCase.FIFLLOGPNMC;
			}
		}

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x0600BB36 RID: 47926 RVA: 0x001F78C7 File Offset: 0x001F5AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFIFLLOGPNMC
		{
			get
			{
				return this.refreshCase_ == SceneEntityRefreshInfo.RefreshOneofCase.FIFLLOGPNMC;
			}
		}

		// Token: 0x0600BB37 RID: 47927 RVA: 0x001F78D3 File Offset: 0x001F5AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFIFLLOGPNMC()
		{
			if (this.HasFIFLLOGPNMC)
			{
				this.ClearRefresh();
			}
		}

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x0600BB38 RID: 47928 RVA: 0x001F78E3 File Offset: 0x001F5AE3
		// (set) Token: 0x0600BB39 RID: 47929 RVA: 0x001F78FA File Offset: 0x001F5AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DeleteEntity
		{
			get
			{
				if (!this.HasDeleteEntity)
				{
					return 0U;
				}
				return (uint)this.refresh_;
			}
			set
			{
				this.refresh_ = value;
				this.refreshCase_ = SceneEntityRefreshInfo.RefreshOneofCase.DeleteEntity;
			}
		}

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x0600BB3A RID: 47930 RVA: 0x001F7910 File Offset: 0x001F5B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDeleteEntity
		{
			get
			{
				return this.refreshCase_ == SceneEntityRefreshInfo.RefreshOneofCase.DeleteEntity;
			}
		}

		// Token: 0x0600BB3B RID: 47931 RVA: 0x001F791C File Offset: 0x001F5B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDeleteEntity()
		{
			if (this.HasDeleteEntity)
			{
				this.ClearRefresh();
			}
		}

		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x0600BB3C RID: 47932 RVA: 0x001F792C File Offset: 0x001F5B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityRefreshInfo.RefreshOneofCase RefreshCase
		{
			get
			{
				return this.refreshCase_;
			}
		}

		// Token: 0x0600BB3D RID: 47933 RVA: 0x001F7934 File Offset: 0x001F5B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearRefresh()
		{
			this.refreshCase_ = SceneEntityRefreshInfo.RefreshOneofCase.None;
			this.refresh_ = null;
		}

		// Token: 0x0600BB3E RID: 47934 RVA: 0x001F7944 File Offset: 0x001F5B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneEntityRefreshInfo);
		}

		// Token: 0x0600BB3F RID: 47935 RVA: 0x001F7954 File Offset: 0x001F5B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneEntityRefreshInfo other)
		{
			return other != null && (other == this || (object.Equals(this.AddEntity, other.AddEntity) && this.FIFLLOGPNMC == other.FIFLLOGPNMC && this.DeleteEntity == other.DeleteEntity && this.RefreshCase == other.RefreshCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB40 RID: 47936 RVA: 0x001F79C4 File Offset: 0x001F5BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.refreshCase_ == SceneEntityRefreshInfo.RefreshOneofCase.AddEntity)
			{
				num ^= this.AddEntity.GetHashCode();
			}
			if (this.HasFIFLLOGPNMC)
			{
				num ^= this.FIFLLOGPNMC.GetHashCode();
			}
			if (this.HasDeleteEntity)
			{
				num ^= this.DeleteEntity.GetHashCode();
			}
			num ^= (int)this.refreshCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BB41 RID: 47937 RVA: 0x001F7A3C File Offset: 0x001F5C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BB42 RID: 47938 RVA: 0x001F7A44 File Offset: 0x001F5C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB43 RID: 47939 RVA: 0x001F7A50 File Offset: 0x001F5C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.refreshCase_ == SceneEntityRefreshInfo.RefreshOneofCase.AddEntity)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.AddEntity);
			}
			if (this.HasFIFLLOGPNMC)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.FIFLLOGPNMC);
			}
			if (this.HasDeleteEntity)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.DeleteEntity);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB44 RID: 47940 RVA: 0x001F7AC8 File Offset: 0x001F5CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.refreshCase_ == SceneEntityRefreshInfo.RefreshOneofCase.AddEntity)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AddEntity);
			}
			if (this.HasFIFLLOGPNMC)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FIFLLOGPNMC);
			}
			if (this.HasDeleteEntity)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DeleteEntity);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BB45 RID: 47941 RVA: 0x001F7B38 File Offset: 0x001F5D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneEntityRefreshInfo other)
		{
			if (other == null)
			{
				return;
			}
			SceneEntityRefreshInfo.RefreshOneofCase refreshCase = other.RefreshCase;
			if (refreshCase != SceneEntityRefreshInfo.RefreshOneofCase.AddEntity)
			{
				if (refreshCase != SceneEntityRefreshInfo.RefreshOneofCase.FIFLLOGPNMC)
				{
					if (refreshCase == SceneEntityRefreshInfo.RefreshOneofCase.DeleteEntity)
					{
						this.DeleteEntity = other.DeleteEntity;
					}
				}
				else
				{
					this.FIFLLOGPNMC = other.FIFLLOGPNMC;
				}
			}
			else
			{
				if (this.AddEntity == null)
				{
					this.AddEntity = new SceneEntityInfo();
				}
				this.AddEntity.MergeFrom(other.AddEntity);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BB46 RID: 47942 RVA: 0x001F7BB7 File Offset: 0x001F5DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB47 RID: 47943 RVA: 0x001F7BC0 File Offset: 0x001F5DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 80U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DeleteEntity = input.ReadUInt32();
						}
					}
					else
					{
						this.FIFLLOGPNMC = input.ReadUInt32();
					}
				}
				else
				{
					SceneEntityInfo sceneEntityInfo = new SceneEntityInfo();
					if (this.refreshCase_ == SceneEntityRefreshInfo.RefreshOneofCase.AddEntity)
					{
						sceneEntityInfo.MergeFrom(this.AddEntity);
					}
					input.ReadMessage(sceneEntityInfo);
					this.AddEntity = sceneEntityInfo;
				}
			}
		}

		// Token: 0x04004BED RID: 19437
		private static readonly MessageParser<SceneEntityRefreshInfo> _parser = new MessageParser<SceneEntityRefreshInfo>(() => new SceneEntityRefreshInfo());

		// Token: 0x04004BEE RID: 19438
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BEF RID: 19439
		public const int AddEntityFieldNumber = 4;

		// Token: 0x04004BF0 RID: 19440
		public const int FIFLLOGPNMCFieldNumber = 10;

		// Token: 0x04004BF1 RID: 19441
		public const int DeleteEntityFieldNumber = 11;

		// Token: 0x04004BF2 RID: 19442
		private object refresh_;

		// Token: 0x04004BF3 RID: 19443
		private SceneEntityRefreshInfo.RefreshOneofCase refreshCase_;

		// Token: 0x02001C0B RID: 7179
		public enum RefreshOneofCase
		{
			// Token: 0x04006438 RID: 25656
			None,
			// Token: 0x04006439 RID: 25657
			AddEntity = 4,
			// Token: 0x0400643A RID: 25658
			FIFLLOGPNMC = 10,
			// Token: 0x0400643B RID: 25659
			DeleteEntity
		}
	}
}
